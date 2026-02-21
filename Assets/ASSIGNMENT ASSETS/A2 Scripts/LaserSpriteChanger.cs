using UnityEngine;
using UnityEngine.UI;


public class LaserSpriteChanger : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] lasers;
    public Slider slider;// for some reason, the slider is not working, and is stating type mismatch, even though I have the slider component attached

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>();
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLaser()
    {
        // change the laser colour the same way we set the sprite colour, but attach it to the slider value
        if (slider.value == 0)
        {
            sr.sprite = lasers[0];
        }
        else if (slider.value == 1)
        {
            sr.sprite = lasers[1];
        }
        else if (slider.value == 2)
        {
            sr.sprite = lasers[2];
        }
        else if (slider.value == 3)
        {
            sr.sprite = lasers[3];
        }
        }
}
