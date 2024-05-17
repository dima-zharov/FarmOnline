using System.Collections;
using UnityEngine;

public class Registration : EntryPattern
{
    [SerializeField] private GameObject _confirmCodePool;
    private void Update()
    {
        try
        {
            if (_request.Uwr.downloadHandler.text.Equals("true") || _request.Uwr.downloadHandler.text.Equals("false"))
                _confirmCodePool.SetActive(true);
            else
            {
                _request.SpawnErrorMessage();
                _confirmCodePool.SetActive(false);
            }

        }
        catch { }
    }
    protected override void EntryMethod()
    {
        StartCoroutine(EntryMethodCoroutine());

    }

    private IEnumerator EntryMethodCoroutine()
    {
        _userPassword = _inputPassword.textComponent.text;
        _userEmail = _inputEmail.textComponent.text;
        yield return StartCoroutine(_request.GetRequest($"https://zetprime.pythonanywhere.com/game/api/registration?email={_userEmail}&password={_userPassword}"));
    }

}
