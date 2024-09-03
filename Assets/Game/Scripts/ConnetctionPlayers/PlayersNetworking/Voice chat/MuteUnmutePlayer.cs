using UnityEngine;

public class MuteUnmutePlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.mute = true;
    }

    public void SetPlayerMuteUnmute(bool isMuting) => _audioSource.mute = isMuting;
}
