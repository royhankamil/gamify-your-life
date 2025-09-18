using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText, startButtonText;
    [SerializeField] private TMP_InputField setMinutesText;
    int seconds = 0, minutes = 0;
    private bool started = false, stopped = false;

    void Start()
    {

    }

    public void StartCount()
    {
        if (!started)
        {
            started = true;
            stopped = false;
            startButtonText.text = "Pause";

            if (minutes == 0 && seconds == 0)
            {
                minutes = setMinutesText.text == "" ? 0 : int.Parse(setMinutesText.text);
                seconds = 0;
            }
            timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
            StartCoroutine(Counter());
        }
        else if (started && !stopped)
        {
            stopped = true;
            startButtonText.text = "Resume";
        }
        else if (started && stopped)
        {
            stopped = false;
            startButtonText.text = "Pause";
        }

    }

    IEnumerator Counter()
    {
        while (minutes > 0 || seconds > 0)
        {
            if (seconds == 0 && minutes > 0 && !stopped)
            {
                minutes--;
                seconds = 59;
            }
            else
            {
                if (!stopped)
                    seconds--;
            }
            timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
            yield return new WaitForSeconds(1f);
        }
    }

    public void ResetCount()
    {
        StopCoroutine(Counter());
        started = false;
        stopped = false;
        if (minutes == 0 && seconds == 0)
        {
            minutes = setMinutesText.text == "" ? 0 : int.Parse(setMinutesText.text);
            seconds = 0;
        }
        timerText.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
    }

    void Update()
    {

    }

}
