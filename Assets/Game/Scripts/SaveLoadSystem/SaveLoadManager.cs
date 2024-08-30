

using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private ISaveLoader[] _saveLoaders;
    private GameRepository _gameRepository = new();
    [SerializeField] private List<GameObject> _objectsToSaveLoad;

    private void Awake()
    {
        _saveLoaders = new[]
        {
            new PlayerDataSaveLoader()
        };

        LoadGame();

    }

    public void SaveGame()
    {
        foreach (var loader in _saveLoaders)
        {
            foreach(var gameObject in _objectsToSaveLoad) 
                loader.SaveGame(gameObject, _gameRepository);
        }

        _gameRepository.SaveGame();
    }

    public void LoadGame()
    {
        _gameRepository.LoadGame();

        foreach (var loader in _saveLoaders)
        {
            foreach (var gameObject in _objectsToSaveLoad)
                loader.LoadGame(gameObject, _gameRepository);
        }
    }
}
