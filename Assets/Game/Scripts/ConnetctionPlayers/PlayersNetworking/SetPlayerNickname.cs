using Photon.Pun;
using Photon.Realtime;

public class SetPlayerNickname
{
    public bool SetPhotonPlayerNickname(string nickname)
    {
        foreach (Player serverPlayer in PhotonNetwork.PlayerList)
        {
            if (serverPlayer.NickName.Equals(nickname))
                return false;
        }
        PhotonNetwork.NickName = nickname;
        return true;
    }
}
