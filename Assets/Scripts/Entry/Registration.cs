using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField] private InputField _inputEmail; 
    [SerializeField] private InputField _inputPassword; 
    [SerializeField] private GameObject _confirmCodePool;

    private Requests request = new Requests();

    private string _userEmail;
    private string _userPassword;


    private void Update()
    {
        if(_inputPassword.textComponent.text != null && _inputEmail.textComponent.text != null)
        {
            _userPassword = _inputPassword.textComponent.text;
            _userEmail = _inputEmail.textComponent.text;

            StartCoroutine(request.postRequest($"http://127.0.0.1:4040/game/api/login?={_userEmail}.com&password?={_userPassword}&secret=secret_api_key"));

            _confirmCodePool.SetActive(true);          
        }
    }

   
}
