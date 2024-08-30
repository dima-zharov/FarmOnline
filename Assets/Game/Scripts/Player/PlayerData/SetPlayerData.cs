using TMPro;
using UnityEngine;

[RequireComponent(typeof(PlayerDataMonoBehaviour))]
public class SetPlayerData : MonoBehaviour
{
    [SerializeField]private SaveLoadManager _saveLoadManager;
    private PlayerDataMonoBehaviour _playerDataMonoBehaviour;
    private TextMeshProUGUI _playerNameText;
    private void Start()
    {
        _playerDataMonoBehaviour = gameObject.GetComponent<PlayerDataMonoBehaviour>();
        _playerNameText = Singleton.Instance.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        _playerNameText.text = _playerDataMonoBehaviour.Name;
    }
}
