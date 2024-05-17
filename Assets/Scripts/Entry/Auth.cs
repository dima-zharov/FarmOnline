using System.Collections;

public class Auth : EntryPattern
{
    private UserIdData _userIdData = new UserIdData();
    private ChangeScene _sceneManager = new ChangeScene();
    private string _result;

    protected override void EntryMethod()
    {
        StartCoroutine(EntryMethodCoroutine());    
    }

    private IEnumerator EntryMethodCoroutine()
    {

        _userPassword = _inputPassword.textComponent.text;
        _userEmail = _inputEmail.textComponent.text;

        yield return StartCoroutine(_request.GetRequest($"https://текст/login?email={_userEmail}&password={_userPassword}"));

        if (_request.Uwr.downloadHandler.Equals("true"))
        {
            _result = _request.Uwr.downloadHandler.text;
            _userIdData.SaveUserId(ref _result);
            _sceneManager.ChangeSceneMethod(1);
        }
        else
            _request.SpawnErrorMessage();
        
    }
}
