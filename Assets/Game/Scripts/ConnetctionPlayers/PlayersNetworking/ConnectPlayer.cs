using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(PlayersSpawner))]
public class ConnectPlayer : MonoBehaviourPunCallbacks
{
    [SerializeField][Range(1, 10)] private int _maxPlayersInRoom;
    [SerializeField] private Initializer _initializer;
    [SerializeField] private PlayerDataMonoBehaviour _playerDataMonoBehaviour;
    private PlayersSpawner _playerSpawner;
    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
        _playerSpawner = GetComponent<PlayersSpawner>();
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("MainRoom", new RoomOptions { MaxPlayers = _maxPlayersInRoom }, null);
    }

    public override void OnJoinedRoom()
    {

        _playerSpawner.SpawnPlayer();

        _initializer.InitializeObjects();
    }

}
