using UnityEngine;
using UnityEngine.Android;

public class MuteUnmutePlayer : MonoBehaviour, IInitializer
{
    private AudioSource _audioSource;

    public void Initialize()
    {
        Permission.RequestUserPermission(Permission.Microphone);
        _audioSource = GetComponent<AudioSource>();
        _audioSource.mute = true;
    }


    public void SetPlayerMuteUnmute(bool isMuting) => _audioSource.mute = isMuting;
}
