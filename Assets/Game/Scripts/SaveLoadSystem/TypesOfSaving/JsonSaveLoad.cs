using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;


public class JsonSaveLoad 
{

    private const string SaveFolderName = "Plants Survivours Online\\Saves";

    private const string SaveFileName = "GameSaveFile.json";

    private static string SaveDataFolder => Path.Combine(Application.persistentDataPath, SaveFolderName);

    private static string SaveFilePath => Path.Combine(SaveDataFolder, SaveFileName);

    public void Save(Dictionary<string, string> objectToSave)
    {
        try
        {
            var serializedData = objectToSave;

            if (!Directory.Exists(SaveDataFolder))
                Directory.CreateDirectory(SaveDataFolder);

            var serializedSaveFile = JsonConvert.SerializeObject(serializedData);

            
            File.WriteAllText(SaveFilePath, serializedSaveFile);
        }
        catch (Exception e)
        {
            Debug.LogException(e);
            throw;
        }
    }

    public void Load(out Dictionary<string, string> gameState)
    {
        if (!File.Exists(SaveFilePath))
        {
            Debug.LogError($"Can't load save file. File {SaveFilePath} is doesn't exist.");
            
        }

        try
        {
            var serializedFile = File.ReadAllText(SaveFilePath);
            if (string.IsNullOrEmpty(serializedFile))
            {
                Debug.LogError($"Loaded file {SaveFilePath} is empty.");
                
            }

            Debug.Log($"Loaded at {SaveFilePath}");
            gameState = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
