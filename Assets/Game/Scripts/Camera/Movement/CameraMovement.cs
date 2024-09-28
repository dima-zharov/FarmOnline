using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private FindLocalPlayer _findLocalPlayer;
    private GameObject _target;
    private Vector3 _targetPosition;



    private void LateUpdate()
    {
        CheckTarget();
    }

    private void CheckTarget()
    {
        if (_target == null)
            _target = _findLocalPlayer.FindLocalPlayerMethod();
        else 
            Move();
    }


    private void Move()
    {
        float playerX = _target.transform.position.x;
        float playerY = _target.transform.position.y;

        playerX = Mathf.Clamp(playerX, BarrierData.LEFT_BARRIER, BarrierData.RIGHT_BARRIER);
        playerY = Mathf.Clamp(playerY, BarrierData.LEFT_BARRIER, BarrierData.RIGHT_BARRIER);
        playerY = Mathf.Clamp(playerY, BarrierData.LEFT_BARRIER, BarrierData.RIGHT_BARRIER);

        _targetPosition = new Vector3(playerX, playerY + 0.8f, _target.transform.position.z - 10);
        transform.position = _targetPosition;
    }

}
