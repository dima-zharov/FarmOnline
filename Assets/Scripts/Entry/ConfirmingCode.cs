using TMPro;
using UnityEngine;

public class ConfirmingCode : MonoBehaviour
{
    private Requests _request;

    private Registration _registration;

    private string _code;
    private string _url;
    private string _userId;


    [SerializeField] private TMP_InputField _inputCode;
    [SerializeField] private TMP_InputField _inputEmail;

    private void Awake()
    {
        _request = new Requests();
        _registration = new Registration();
    }

    public void ConfirmingCodeMethod()
    {

        _url = $"https://zetprime.pythonanywhere.com/game/api/validate?email={_inputEmail.text}&code={_inputCode.text}";

        _url = _request.CleanUrl(_url);

        StartCoroutine(_request.getRequest(_url));

        Debug.Log(_url);

        _code = _request.uwr.downloadHandler.text;

        if (_inputCode.text == _code)
        {
            _userId = _request.uwr.downloadHandler.text;
            _userId = UserIdData.UserId;

            gameObject.SetActive(false);
        }
    }
}
