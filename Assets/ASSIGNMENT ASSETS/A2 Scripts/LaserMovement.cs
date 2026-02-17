using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public GameObject laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * 10f; // Move the laser upwards at a speed of 10 units per second

        // Destroy the laser after it goes off-screen

        Vector2 laserPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (laserPosition.y >= Screen.height)
        {
            Destroy(laser);
        }
    }
}
