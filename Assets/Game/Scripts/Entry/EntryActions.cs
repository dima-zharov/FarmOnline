using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent (typeof(ChangeScene))]
public class EntryActions : MonoBehaviourPunCallbacks
{
    [SerializeField][Range(1, 10)] private int _maxPlayersInRoom;
    [SerializeField] private ChangeScene _changeScene;
    public void SucessfulEntryMethod()
    {
        PhotonNetwork.JoinOrCreateRoom("MainRoom", new RoomOptions { MaxPlayers = 10 }, null);

    }

    public void FailedEntryMethod(string message)
    {
        _changeScene.ErrorChangeScene(message);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
