using UnityEngine;

public class PlayersInfoPrefabData : MonoBehaviour
{
    public string Nickname { get; private set; }

    public void SetNickname(string value) => Nickname = value;
}
