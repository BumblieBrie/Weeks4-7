using UnityEngine;
using UnityEngine.InputSystem;

public class LaserSpawner : MonoBehaviour
{
    public GameObject laserPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
