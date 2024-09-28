using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private SwitchSceneTransitionInfo _transitionInfo;
    public void ChangeSceneMethod(int sceneId)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneId);
        _transitionInfo.SetSceneTransitionInfoActivity(asyncOperation.isDone);
    }

    public void ErrorChangeScene(string message)
    {
        _transitionInfo.ShowTransitionException(message);
    }


}
