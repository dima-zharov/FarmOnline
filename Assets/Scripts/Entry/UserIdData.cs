using UnityEngine;
public class UserIdData
{
    public static string UserId { get; private set; }

    public void SaveUserId(ref string userId)
    {
        UserId = userId;
        PlayerPrefs.SetString("playerId", UserId);
        PlayerPrefs.Save();
    }
}
