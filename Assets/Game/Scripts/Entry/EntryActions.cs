using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(ChangeScene))]
public class EntryActions : MonoBehaviourPunCallbacks
{
    [SerializeField][Range(1, 10)] private int _maxPlayersInRoom;
    [SerializeField] private SwitchSceneTransitionInfo _switchSceneTransitionInfo;
    public void SucessfulEntryMethod()
    {
        StartCoroutine(LoadLevelCoroutine());
    }

    public void FailedEntryMethod(string message)
    {
        _switchSceneTransitionInfo.ShowTransitionException(message);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    private IEnumerator LoadLevelCoroutine()
    {
        _switchSceneTransitionInfo.SetSceneTransitionInfoActivity(true);
        yield return null; 
        PhotonNetwork.JoinOrCreateRoom("MainRoom", new RoomOptions { MaxPlayers = _maxPlayersInRoom }, null);
    }
}
