using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class ConectPlayer : MonoBehaviourPunCallbacks
{
    [SerializeField][Range(1, 10)] private int _maxPlayersInRoom;
    [SerializeField] private PlayerDataMonoBehaviour _playerDataMonoBehaviour;
    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();

    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("MainRoom", new RoomOptions { MaxPlayers = _maxPlayersInRoom }, null);
    }
    public override void OnJoinedRoom()
    {
        string playerNickname = _playerDataMonoBehaviour.Name;

        PhotonNetwork.LocalPlayer.NickName = playerNickname;
        
    }
}
