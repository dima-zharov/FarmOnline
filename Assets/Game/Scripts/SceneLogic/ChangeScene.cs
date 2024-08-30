using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    [SerializeField] protected SwitchSceneTransitionInfo _transitionInfo;
    public void ChangeSceneMethod(int sceneId)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneId);
        _transitionInfo.SetSceneTransitionInfoActivity(asyncOperation.isDone);
    }

}
