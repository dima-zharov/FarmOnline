using UnityEngine;

public class MuteUnmutePlayer : MonoBehaviour, IInitializer
{
    [SerializeField]private AudioSource _audioSource;
    private MicroPermisiion microPermision = new();

    public void Initialize()
    {
        if (microPermision.IsPermissionForMicro())
            SetAudioSource();
    }

    private void SetAudioSource()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.mute = true;
    }


    public void SetPlayerMuteUnmute(bool isMuting) => _audioSource.mute = isMuting;
}
