using Photon.Pun;
using UnityEngine;

public class PlayersSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public void SpawnPlayer()
    {
        Debug.Log("<color=yellow> Player has spawned</color>");
        PhotonNetwork.Instantiate(_player.name, Vector2.zero, Quaternion.identity);
    }
}
