using UnityEngine;

[RequireComponent (typeof(ChangeScene))]
public class EntryActions : ChangeScene
{
    public void SucessfulEntryMethod()
    {
        ChangeSceneMethod(1);
    }

    public void FailedEntryMethod(string message)
    {
        _transitionInfo.ShowTransitionException(message);
    }
}
