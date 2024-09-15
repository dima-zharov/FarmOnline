using UnityEngine;

public class OnClickMuteUnmutePlayer : MonoBehaviour, IInitializer
{
    [SerializeField] private GameObject _player;
    private MuteUnmutePlayer _playerAudio;
    private bool _isMuting = true;
    public void Initialize()
    {
        _playerAudio = _player.GetComponent<MuteUnmutePlayer>();
    }

    public void SecondInitialize()
    {
        throw new System.NotImplementedException();
    }

    public void SetMuteUnmute()
    {
        _playerAudio.SetPlayerMuteUnmute(_isMuting);
        _isMuting = !_isMuting;
    }
}
