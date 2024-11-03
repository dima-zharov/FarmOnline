using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class SwitchSceneTransitionInfo : MonoBehaviour
{
    [SerializeField] private GameObject _errorPanel;
    [SerializeField] private GameObject _transitionInfoPanel;
    [SerializeField] private float _timeToShowError;
    private bool _isMessageActive;
    private TextMeshProUGUI _textMeshPro;
    private AsyncOperation _asyncOperation;

    private void Awake()
    {
        _textMeshPro = _errorPanel.GetComponentInChildren<TextMeshProUGUI>();
        _errorPanel.SetActive(false);
        _transitionInfoPanel.SetActive(false);
    }
    public void SetSceneTransitionInfoActivity(bool isSceneLoading)
    {
        _transitionInfoPanel.SetActive(isSceneLoading);
    }

    public  void ShowTransitionException(string message)
    {
        if (!_isMessageActive)
        {
            StartCoroutine(ShowExeptionCoroutine(message));
            _errorPanel.SetActive(true);
        }
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
        _errorPanel.SetActive(isActive);
    }
}