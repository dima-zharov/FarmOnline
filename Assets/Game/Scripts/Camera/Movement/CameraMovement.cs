using UnityEngine;

public class CameraMovement : BarrierData
{
    private GameObject _player;



    private Vector3 _targetPosition;

    private void Start()
    {
       _player = Singleton.Instance.gameObject;
    }

    private void LateUpdate()
    {
        Move();
    }

    
    private void Move()
    {
        float playerX = _player.transform.position.x;
        float playerY = _player.transform.position.y;

        playerX =  Mathf.Clamp(playerX, LEFT_BARRIER, RIGHT_BARRIER);
        playerY = Mathf.Clamp(playerY, DOWN_BARRIER, UP_BARRIER);

        _targetPosition = new Vector3(playerX, playerY + 0.8f, _player.transform.position.z - 10);
        transform.position = _targetPosition;
    }

}
