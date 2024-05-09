using System.Threading;
using UnityEngine;

public class Auth : EntryPattern
{
    private UserIdData _userIdData = new UserIdData();
    private ChangeScene _sceneManager = new ChangeScene();
    protected override void EntryMethod()
    {

        _userPassword = _inputPassword.textComponent.text;
        UserEmail = _inputEmail.textComponent.text;

        StartCoroutine(_request.getRequest($"https://zetprime.pythonanywhere.com/game/api/login?email={UserEmail}&password={_userPassword}"));

        if (_request.uwr.downloadHandler.Equals("false"))
            Debug.Log("Error in emeil or password, try again");
        else
        {
            Debug.Log("Sucessful! Your id " + _request.uwr.downloadHandler.text);
            string result = _request.uwr.downloadHandler.text;
            Thread.Sleep(5000);
            _userIdData.SaveUserId(ref result);
            _sceneManager.ChangeSceneMethod(1);
        }

    }
}
