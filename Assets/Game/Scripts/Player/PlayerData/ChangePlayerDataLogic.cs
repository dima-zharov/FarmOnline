using TMPro;
using UnityEngine;

[RequireComponent(typeof(PlayerDataMonoBehaviour))]
public class ChangePlayerDataLogic : MonoBehaviour
{
    private PlayerDataMonoBehaviour _playerData;
    private void Start()
    {
        _playerData = GetComponent<PlayerDataMonoBehaviour>();  
    }
    public void ChangeName(TextMeshProUGUI emailText)
    {
        _playerData.Name = emailText.text;
    }
}
