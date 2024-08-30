
using UnityEngine;

public interface ISaveLoader
{
    void SaveGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository);
    void LoadGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository);
}
