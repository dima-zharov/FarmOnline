using Photon.Pun;
using UnityEngine;

public class FindLocalPlayer : MonoBehaviourPunCallbacks
{
    public GameObject FindLocalPlayerMethod()
    {
        PhotonView[] players = FindObjectsOfType<PhotonView>();

        foreach (var player in players) 
        {
            if (player.Owner.IsLocal)
                return player.gameObject;
        }

        return default;
    }
}
