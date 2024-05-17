using System.Collections;
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
        StartCoroutine(ConfirmingCodeCorroutine());
    }

    private IEnumerator ConfirmingCodeCorroutine()
    {
        yield return StartCoroutine(_request.GetRequest($"https://zetprime.pythonanywhere.com/game/api/validate?email={_inputEmail.text}&code={_code}"));


        if (_inputCode.text == _code)
        {
            _userId = _request.Uwr.downloadHandler.text;
            _userIdData.SaveUserId(ref _userId);
            _sceneManager.ChangeSceneMethod(1);
        }
    }
}
