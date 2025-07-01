using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    int setMinutes = 2, seconds = 0, minutes = 0;

    void Start()
    {

    }

    public void StartCount()
    {
        if (minutes == 0 && seconds == 0)
        {
            minutes = setMinutes;
            seconds = 0;
        }
        timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
        StartCoroutine(Counter());
    }

    IEnumerator Counter()
    {
        while (minutes > 0 || seconds > 0)
        {
            if (seconds == 0)
            {
                if (minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
            }
            else
            {
                seconds--;
            }
            timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
            yield return new WaitForSeconds(1f);
        }
    }

    public void StopCount()
    {
        StopCoroutine(Counter());
    }

    void Update()
    {
        
    }
}
