using Photon.Pun;
using UnityEngine;

public class PlayersSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public void SpawnPlayer()
    {
        PhotonNetwork.Instantiate(_player.name, Vector2.zero, Quaternion.identity);
    }
}
