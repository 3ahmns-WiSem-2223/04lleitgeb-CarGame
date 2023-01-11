using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float startingTime;
    [SerializeField] Text timerText;

    void Start()
    {
        startingTime = Time.time;
    }
    void Update()
    {
        float time = Time.time - startingTime;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f0");

        timerText.text = "Timer: " + minutes + ":" + seconds;
    }
}

