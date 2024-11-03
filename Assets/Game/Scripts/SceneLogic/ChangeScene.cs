using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private SwitchSceneTransitionInfo _transitionInfo;
    public void ChangeSceneMethod(int sceneId)
    {
        _transitionInfo.SetSceneTransitionInfoActivity(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneId);
    }

    public void ErrorChangeScene(string message)
    {
        _transitionInfo.ShowTransitionException(message);
    }


}
