
using UnityEngine;

public abstract class SaveLoader<TData, TObjectToSaveLoad> : ISaveLoader
{
    public void LoadGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository)
    {

        if (gameRepository.TryGetData(out TData data))
        {
            var dataMonoBehaviour = gameObjectToSaveLoad.GetComponent<TObjectToSaveLoad>();
            SetUpData(data, dataMonoBehaviour);

        }
    }


    public void SaveGame(GameObject gameObjectToSaveLoad, IGameRepository gameRepository)
    {
        var dataMonoBehaviour = gameObjectToSaveLoad.GetComponent<TObjectToSaveLoad>();
        TData data = GetObjectData(dataMonoBehaviour);

        gameRepository.SetData(data);
    }

    protected abstract TData GetObjectData(TObjectToSaveLoad @obj);
    protected abstract void SetUpData(TData data, TObjectToSaveLoad @object);
}
