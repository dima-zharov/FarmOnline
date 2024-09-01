using System;
using UnityEngine;

public class PlayerPositionController : MonoBehaviour
{
    private void Awake()
    {
        Singleton.Instance.transform.position = Vector2.zero;
    }
}
