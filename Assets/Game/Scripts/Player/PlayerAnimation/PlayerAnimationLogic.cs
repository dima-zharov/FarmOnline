using UnityEngine;

public class PlayerAnimationLogic : BaseAnimationLogic
{
    private Joystick _joystick;
    protected override void Start()
    {
        base.Start();
        _joystick = GameObject.FindObjectOfType<Joystick>();
    }
    private void FixedUpdate()
    {
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
