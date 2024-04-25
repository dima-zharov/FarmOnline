using TMPro;
using UnityEngine;

public abstract class EntryPattern : MonoBehaviour
{
    [SerializeField] protected TMP_InputField _inputEmail;
    [SerializeField] protected TMP_InputField _inputPassword;


    protected Requests _request;

    protected string UserEmail;
    protected string _userPassword;
    protected string _url;

    protected void Awake()
    {
        _request = new Requests();
    }

    protected void EnterField()
    {
        if (_inputPassword.textComponent.text != null && _inputEmail.textComponent.text != null)
            EntryMethod();
    }

    protected abstract void EntryMethod();
}
