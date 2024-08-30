using System.Collections;
using TMPro;
using UnityEngine;

public class SwitchSceneTransitionInfo : MonoBehaviour
{
    [SerializeField] private GameObject _infoPanel;
    [SerializeField] private float _timeToShowError;
    private bool _isMessageActive;
    private TextMeshProUGUI _textMeshPro;

    private void Awake()
    {
        _textMeshPro = _infoPanel.GetComponentInChildren<TextMeshProUGUI>();
        _infoPanel.SetActive(false);
    }
    public void SetSceneTransitionInfoActivity(bool isSceneLoading)
    {
        ChangePanelView(Color.white, "Loading...", false);
        _infoPanel.SetActive(!isSceneLoading);
    }

    public void ShowTransitionException(string message)
    {
        if(!_isMessageActive)
            StartCoroutine(ShowExeptionCoroutine(message));
    }

    private IEnumerator ShowExeptionCoroutine(string message)
    {
        ChangePanelView(Color.red, message, true);
        yield return new WaitForSeconds(_timeToShowError);
        ChangePanelView(Color.white, "Loading...", false);
    }

    private void ChangePanelView(Color color, string text, bool isActive)
    {
        _isMessageActive = isActive;
        _textMeshPro.color = color;
        _textMeshPro.text = text;
        _infoPanel.SetActive(isActive);
    }
}
