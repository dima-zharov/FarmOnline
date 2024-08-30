using UnityEngine;

public class JoystickMovement : PlayerMovement
{
     private Joystick _joystick;
    private void Awake()
    {
        FindJoystick();
    }
    protected override void MovePlayer()
    {
        Vector2 moveDirection = _joystick.Direction;
        Vector2 offset = moveDirection * _moveSpeed * Time.fixedDeltaTime;
        CheckViewDirection(moveDirection);
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    private void FindJoystick()
    {
        _joystick= GameObject.FindObjectOfType<Joystick>();
    }
}
