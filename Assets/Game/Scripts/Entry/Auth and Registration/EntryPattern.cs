using System.Collections;
using TMPro;
using UnityEngine;

public abstract class EntryPattern : MonoBehaviour
{
    [SerializeField] protected TMP_InputField _inputEmail;
    [SerializeField] protected TMP_InputField _inputPassword;
    [SerializeField] EntryActions _entryActions;
    protected Requests _request = new();

    protected string _userEmail;
    protected string _userPassword;

    private const string SUCESSFUL_REQUEST_TEXT = "true";
    private SetPlayerNickname _setPhotonPlayerNickname = new();

    public void EnterField()
    {
        if (_inputPassword.textComponent.text != null && _inputEmail.textComponent.text != null)
            EntryMethod(ReturnUrl());
           
    }

    protected abstract string ReturnUrl();


    protected void EntryMethod(string url)
    {
        StartCoroutine(EntryMethodCoroutine(url));
    }

    protected IEnumerator EntryMethodCoroutine(string url)
    {
        _userPassword = _inputPassword.textComponent.text;
        _userEmail = _inputEmail.textComponent.text;
        yield return StartCoroutine(_request.GetRequest(url));

        string result = _request.UwrMessage;

        if (_setPhotonPlayerNickname.SetPhotonPlayerNickname(_userEmail) && result.Equals(SUCESSFUL_REQUEST_TEXT) )
        {
            _entryActions.SucessfulEntryMethod();
        }
        else if (_setPhotonPlayerNickname.SetPhotonPlayerNickname(_userEmail).Equals(false))
        {
            _entryActions.FailedEntryMethod("This player is already in game!");
        }
        else
        {
            _entryActions.FailedEntryMethod(result);    
        }
    }
}
