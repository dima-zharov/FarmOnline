using UnityEngine;
using UnityEngine.SceneManagement;

public class JoystickMovement : PlayerMovement, IInitializer
{
    private Joystick _joystick;

    public void Initialize()
    {
        _joystick = FindObjectOfType<FloatingJoystick>();
    }
    protected override void MovePlayer()
    {
        MoveMethod();
    }

    public override void MoveMethod()
    {
        if (_joystick != null)
        {
            Vector2 moveDirection = _joystick.Direction;
            Vector2 offset = moveDirection * _moveSpeed * Time.fixedDeltaTime;
            CheckViewDirection(moveDirection);
            _rigidbody?.MovePosition(_rigidbody.position + offset);

        }
    }
}
