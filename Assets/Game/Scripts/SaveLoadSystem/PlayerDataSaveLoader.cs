
using UnityEngine;

public class PlayerData
{
    public string Name;
}
public class PlayerDataSaveLoader : ISaveLoader
{

    public void LoadGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository)
    {

        if(gameRepository.TryGetData(out PlayerData data))
        {
            PlayerDataMonoBehaviour playerDataMonoBehaviour = gameObjectToSaveLoad.GetComponent<PlayerDataMonoBehaviour>();
            playerDataMonoBehaviour.Name = data.Name;
        }
    }


    public void SaveGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository)
    {
        PlayerDataMonoBehaviour playerDataMonoBehaviour = gameObjectToSaveLoad.GetComponent<PlayerDataMonoBehaviour>();
        gameRepository.SetData(new PlayerData
        {
            Name = playerDataMonoBehaviour.Name,
        });
    }
}
