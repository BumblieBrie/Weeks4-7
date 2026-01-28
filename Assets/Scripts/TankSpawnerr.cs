using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawnerr : MonoBehaviour
{
    public GameObject tankPrefab; // Reference to the tank prefab

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(tankPrefab);
        }
    }
}
