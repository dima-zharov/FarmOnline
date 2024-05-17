using Photon.Pun;
public class PlayersInfoPrefabData : MonoBehaviourPunCallbacks
{
    private int _id;

    protected void SetIdPrivate(int id)
    {
        _id = id;
    }

    protected int GetIdPrivate()
    {
        return _id;
    }

    public void SetId(int id)
    {
        SetIdPrivate(id);
    }

    public int GetId()
    {
        return GetIdPrivate();
    }
}