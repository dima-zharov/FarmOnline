using TMPro;
using UnityEngine;

[RequireComponent(typeof(PlayerDataMonoBehaviour))]
public class SetPlayerData : MonoBehaviour, IInitializer
{
    [SerializeField] private FindLocalPlayer _findLocalPlayer;
    [SerializeField] private SaveLoadManager _saveLoadManager;
    private GameObject _player;
    private PlayerDataMonoBehaviour _playerDataMonoBehaviour;
    private TextMeshProUGUI _playerNameText;

    public void Initialize()
    {
        _player = _findLocalPlayer.FindLocalPlayerMethod();
        _playerDataMonoBehaviour = gameObject.GetComponent<PlayerDataMonoBehaviour>();
        _playerNameText = _player.GetComponentInChildren<TextMeshProUGUI>();
        _playerNameText.text = _playerDataMonoBehaviour.Name;
    }

}
