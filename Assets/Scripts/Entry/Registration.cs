using System.Collections;
using TMPro;
using UnityEngine;

public class Registration : MonoBehaviour
{
    [SerializeField] private TMP_InputField   _inputEmail; 
    [SerializeField] private TMP_InputField _inputPassword; 
    [SerializeField] private GameObject _confirmCodePool;

    private Requests request = new Requests();

    private string _userEmail;
    private string _userPassword;
    private string _url;

    public void EnterField()
    {
        if(_inputPassword.textComponent.text != null && _inputEmail.textComponent.text != null)
        {
            _userPassword = _inputPassword.textComponent.text;
            _userEmail = _inputEmail.textComponent.text;

            _url = $"https://zetprime.pythonanywhere.com/game/api/registration?email={_userEmail}&password={_userPassword}";

            _url = request.CleanUrl(_url);

            StartCoroutine(request.getRequest(_url));
        }
    }

    private void Update()
    {
        if (request.uwr.downloadHandler.text.Equals("true") || request.uwr.downloadHandler.text.Equals("false"))
            _confirmCodePool.SetActive(true);
        else
            _confirmCodePool.SetActive(true);

    }
}
