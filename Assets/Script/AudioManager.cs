using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource[] backgroundMusicSource;
    [SerializeField] private Slider[] volumeSlider;

    private void Start()
    {
        for (int i = 0; i < volumeSlider.Length; i++)
        {
            volumeSlider[i].value = backgroundMusicSource[i].volume;
            int sliderIndex = i;
            volumeSlider[sliderIndex].onValueChanged.AddListener((float volume) => SetBackgroundMusicVolume(volume, sliderIndex));
        }
    }

    public void SetBackgroundMusicVolume(float volume, int index)
    {
        backgroundMusicSource[index].volume = volume;
    }
}
