using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 5;

    public AudioSource audioSource;
    public AudioClip chompSFX;
    public AudioClip deathSFX;

    // AudioSource.Play() plays the current audio and stops and restarts it
    // AudioSource.PlayOneShot(MyClip) plays my clip and will play on top of the last sound

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position, is it inside the sprite? are they clicking a button
        // yes to both, take one off health
        // update the value that the slider has
        // update the health bar with the new health value

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if(player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            health--;
    
            if(health <= 0)
            {
                audioSource.clip = deathSFX;
                audioSource.Play();
                gameObject.SetActive(false);
            }
            else
            {
                audioSource.clip = chompSFX;
                audioSource.Play();
            }
        }
        healthBar.value = health;
    }
    public void HealThePlayer()
    {
        gameObject.SetActive(true);
        health = (int)healthBar.maxValue;
        healthBar.value = health;
    }
}
