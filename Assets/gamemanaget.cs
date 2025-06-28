using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;    

public class gamemanaget : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioMixer audioMixer;
    public Slider sliderAS;
    public Slider sliderAM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float volume;
        sliderAS.value = audioSource.volume;
        if (audioMixer.GetFloat("Main", out volume))
            sliderAM.value = volume;

    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = sliderAS.value;
        audioMixer.SetFloat("Main", sliderAM.value);
    }
}
