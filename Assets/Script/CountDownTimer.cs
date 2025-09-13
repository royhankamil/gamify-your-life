using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TMP_InputField setMinutesText;
    int seconds = 0, minutes = 0;
    private bool started = false, stopped;

    void Start()
    {

    }

    public void StartCount()
    {
        if (!started)
        {
            started = true;
            if (minutes == 0 && seconds == 0)
            {
                minutes = setMinutesText.text == "" ? 0 : int.Parse(setMinutesText.text);
                seconds = 0;
            }
            timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
            StartCoroutine(Counter());
        }

    }

    IEnumerator Counter()
    {
        while (minutes > 0 || seconds > 0 || stopped)
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
        if (started && !stopped)
        {
            stopped = true;
            StopCoroutine(Counter());
        }
        else if (stopped)
        {
            stopped = false;
            StartCoroutine(Counter());
        }
    }

    void Update()
    {

    }

}
