using UnityEngine;

public class Auth : EntryPattern
{
    protected override void EntryMethod()
    {

        _userPassword = _inputPassword.textComponent.text;
        UserEmail = _inputEmail.textComponent.text;

        _request.MakeRequestAuth(out _url, ref UserEmail, ref _userPassword);
        StartCoroutine(_request.getRequest(_url));

        if (_request.uwr.downloadHandler.Equals("false"))
            Debug.Log("Error in emeil or password, try again");
        else
        {
            Debug.Log("Sucessful! Your id " + _request.uwr.downloadHandler.text);
            UserIdData.UserId = _request.uwr.downloadHandler.text;
        }

    }
}
