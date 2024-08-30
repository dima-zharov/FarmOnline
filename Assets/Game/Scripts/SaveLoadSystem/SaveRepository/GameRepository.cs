
using Newtonsoft.Json;
using System.Collections.Generic;

public class GameRepository : IGameRepository
{
    private Dictionary<string, string> _gameState = new();
    private JsonSaveLoad _jsonSaveLoad = new();
    public void SetData<T>(T data)
    {
        string key = typeof(T).ToString();
        string serializedData = JsonConvert.SerializeObject(data);
        _gameState[key] = serializedData;
    }

    public bool TryGetData<T>(out T data)
    {
        string key = typeof(T).ToString();

        if (_gameState.TryGetValue(key, out string serializedData))
        {
            data = JsonConvert.DeserializeObject<T>(serializedData);
            return true;
        }

        data = default;
        return false;
    }

    public void LoadGame()
    {
        _jsonSaveLoad.Load(out _gameState);
    }

    public void SaveGame() 
    {
        _jsonSaveLoad.Save(_gameState);
    }
}
