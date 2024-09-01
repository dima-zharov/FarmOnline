using Photon.Pun;
using UnityEngine;

public class PlayersSpawner : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject _player;
    private const int UP_POSITION = 6;
    public override void OnJoinedRoom()
    {
        Vector2 spawnPosition = new Vector2(0, UP_POSITION);
        PhotonNetwork.InstantiateRoomObject(_player.name, spawnPosition, Quaternion.identity);
    }
}
