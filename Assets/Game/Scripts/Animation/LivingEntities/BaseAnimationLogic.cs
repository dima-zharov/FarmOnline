using UnityEngine;

public abstract class BaseAnimationLogic : MonoBehaviour
{
    private Animator _animator;

    protected virtual void Start()
    {
        _animator = gameObject.GetComponentInChildren<Animator>();
    }


    protected void BoolParameterChanging(bool animState, AnimParametersEnum parameterName) =>
        _animator.SetBool(parameterName.ToString(), animState);

    protected void TriggerParameterChanging(AnimParametersEnum parameterName) =>
        _animator.SetTrigger(parameterName.ToString());



}
