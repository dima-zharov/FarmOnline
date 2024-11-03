using UnityEngine;


public class PlayerAnimationLogic : BaseAnimationLogic, IInitializer
{
    private Joystick _joystick;

    public void Initialize()
    {
        _joystick = FindObjectOfType<FloatingJoystick>();
    }
    private void FixedUpdate()
    {
        if (_joystick != null)
            ChangeAnimState(_joystick.Direction);
    }


    private void ChangeAnimState(Vector2 moveDirection)
    {
        if (moveDirection == Vector2.zero)
            BoolParameterChanging(false, AnimParametersEnum.isRunning);
        else
            BoolParameterChanging(true, AnimParametersEnum.isRunning);
    }
}
