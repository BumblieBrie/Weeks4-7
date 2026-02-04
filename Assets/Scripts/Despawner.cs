using UnityEngine;
using UnityEngine.InputSystem;

public class Despawner : MonoBehaviour
{
    public GameObject duckiePrefab;
    public Vector2 duckySpawnLoc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gameObject refers to the game object this script is attached to
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        // spawn ducky where the mouse is clicked
        duckySpawnLoc = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(duckiePrefab, duckySpawnLoc, Quaternion.identity);
        }
    }
}
