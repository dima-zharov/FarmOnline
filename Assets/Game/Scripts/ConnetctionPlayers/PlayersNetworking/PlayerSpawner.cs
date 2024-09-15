using Photon.Pun;
using UnityEngine;

public class PlayersSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public void SpawnPlayer()
    {
        Vector2 spawnPosition = new Vector2(0, 0);
        PhotonNetwork.InstantiateRoomObject(_player.name, spawnPosition, Quaternion.identity);
    }
}
