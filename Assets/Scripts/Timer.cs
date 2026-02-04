using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 0f;
    public float timerMax = 10f;

    // get a hold of the slider component from the UI
    public Slider timerVisuals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisuals.maxValue = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        // make sure to update the timer value and the slider value so that the visuals work
        timerValue += Time.deltaTime;
        timerVisuals.value = timerValue;

        if (timerValue >= timerMax)
        {
            timerValue = 0f;
        }
    }
}
