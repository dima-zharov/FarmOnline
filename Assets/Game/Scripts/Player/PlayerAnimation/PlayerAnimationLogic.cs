using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerAnimationLogic : BaseAnimationLogic
{
    private Joystick _joystick;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
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
