using UnityEngine;

public class MuteUnmutePlayer : MonoBehaviour, IInitializer
{
    private AudioSource _audioSource;

    public void Initialize()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.mute = true;
    }


    public void SetPlayerMuteUnmute(bool isMuting) => _audioSource.mute = isMuting;
}
