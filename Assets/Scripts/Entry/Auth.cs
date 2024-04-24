using TMPro;
using UnityEngine;

public class Auth : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputEmail;
    [SerializeField] private TMP_InputField _inputPassword;

    private Requests request = new Requests();

    private string _userEmail;
    private string _userPassword;
    private string _url;
    public void EnterField()
    {
        if (_inputPassword.textComponent.text != null && _inputEmail.textComponent.text != null)
        {
            _userPassword = _inputPassword.textComponent.text;
            _userEmail = _inputEmail.textComponent.text;

            _url = $"https://zetprime.pythonanywhere.com/game/api/login?email={_userEmail}&password={_userPassword}";
            _url = request.CleanUrl(_url);

            StartCoroutine(request.getRequest(_url));

            if (request.uwr.downloadHandler.Equals("false"))
                Debug.Log("Error in emeil or password, try again");
            else
                Debug.Log("Sucessful! Your id " + request.uwr.downloadHandler.ToString());
        }
    }

}
