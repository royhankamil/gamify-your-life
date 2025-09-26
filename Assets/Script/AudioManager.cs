using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusicSource;
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {   
        volumeSlider.value = backgroundMusicSource.volume;
    }

    public void SetBackgroundMusicVolume(float volume)
    {
        backgroundMusicSource.volume = volume;
    }
}
