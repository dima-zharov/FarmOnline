using Photon.Voice.PUN;
using UnityEngine;

public class OnClickMuteUnmutePlayer : MonoBehaviour, IInitializer
{
    [SerializeField] FindLocalPlayer _localPlayerSearcher;
    private PhotonVoiceView _voiceView;
    private GameObject _player;
    private MuteUnmutePlayer _playerAudio;
    private bool _isMuting = true;

    public void Initialize()
    {
        _player = _localPlayerSearcher.FindLocalPlayerMethod();
        _voiceView = _player.GetComponent<PhotonVoiceView>();
        _playerAudio = _player.GetComponent<MuteUnmutePlayer>();
    }

    public void SetMuteUnmute()
    {
        Debug.Log($"IsRecording: {_voiceView.IsRecording}");
        _playerAudio.SetPlayerMuteUnmute(_isMuting);
        _isMuting = !_isMuting;
    }
}
