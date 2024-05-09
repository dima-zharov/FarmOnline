using System.Threading;
using TMPro;
using UnityEngine;

public class ConfirmingCode : MonoBehaviour
{
    private Requests _request;

    private string _code = "000000";
    private string _url;
    private string _userId;

    private ChangeScene _sceneManager = new ChangeScene();
    private UserIdData _userIdData = new UserIdData();

    [SerializeField] private TMP_InputField _inputCode;
    [SerializeField] private TMP_InputField _inputEmail;

    private void Awake()
    {
        _request = new Requests();
    }

    public void ConfirmingCodeMethod()
    {
        StartCoroutine(_request.getRequest($"https://zetprime.pythonanywhere.com/game/api/validate?email={_inputEmail.text}&code={_code}"));

        Thread.Sleep(5000);

        if (_inputCode.text == _code)
        {
            _userIdData.SaveUserId(ref _userId);
            _sceneManager.ChangeSceneMethod(1);
            _userId = _request.uwr.downloadHandler.text;
        }
    }
}
