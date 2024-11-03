
using UnityEngine;

public class PlayerData
{
    public string Name;
}
public class PlayerDataSaveLoader : SaveLoader<PlayerData, PlayerDataMonoBehaviour>
{

    protected override PlayerData GetObjectData(PlayerDataMonoBehaviour obj)
    {
        PlayerData data = new PlayerData
        {
            Name = obj.Name
        };
        return data;
    }

    protected override void SetUpData(PlayerData data, PlayerDataMonoBehaviour @object)
    {
        @object.Name = data.Name;
    }
}
