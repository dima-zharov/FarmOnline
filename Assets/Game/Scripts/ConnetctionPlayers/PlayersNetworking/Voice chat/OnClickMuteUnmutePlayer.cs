using UnityEngine;

public class OnClickMuteUnmutePlayer : MonoBehaviour
{
    private bool _isMuting = true;
    private MuteUnmutePlayer _playerAudio;
    private void Start()
    {
        _playerAudio = Singleton.Instance.GetComponent<MuteUnmutePlayer>();
    }
    public void SetMuteUnmute()
    {
        _playerAudio.SetPlayerMuteUnmute(_isMuting);
        _isMuting = !_isMuting;
    }
}
