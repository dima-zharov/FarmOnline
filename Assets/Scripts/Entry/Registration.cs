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

        _request.MakeRequestRegistrtion(out _url, ref UserEmail, ref _userPassword);
        StartCoroutine(_request.getRequest(_url));

    }

}
