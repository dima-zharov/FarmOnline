using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(gameObject);
    }
}
