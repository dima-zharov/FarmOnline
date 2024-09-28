using Photon.Pun;
using UnityEngine;

public class DisconnectServer : MonoBehaviourPunCallbacks
{
    public void Disconnect() => PhotonNetwork.LeaveRoom();
}
