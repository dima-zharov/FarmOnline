using UnityEngine;
public class UserIdData
{
    public static string UserId;

    public void SaveUserId(ref string userId)
    {
        UserId = userId;
        PlayerPrefs.SetString("playerId", UserId);
        PlayerPrefs.Save();
    }
}
