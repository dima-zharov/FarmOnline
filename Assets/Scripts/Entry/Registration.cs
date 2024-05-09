using UnityEngine;

public class Registration : EntryPattern
{
    [SerializeField] private GameObject _confirmCodePool;
    private void Update()
    {
        try
        {
            if (_request.uwr.downloadHandler.text.Equals("true") || _request.uwr.downloadHandler.text.Equals("false"))
                _confirmCodePool.SetActive(true);
            else
                _confirmCodePool.SetActive(false);

        }
        catch { }
    }
    protected override void EntryMethod()
    {
        _userPassword = _inputPassword.textComponent.text;
        UserEmail = _inputEmail.textComponent.text;
        StartCoroutine(_request.getRequest($"https://zetprime.pythonanywhere.com/game/api/registration?email={UserEmail}&password={_userPassword}"));

    }

}
