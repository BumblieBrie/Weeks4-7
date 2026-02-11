using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class BulletScript : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject spawnedBullet;
    public float t = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            spawnedBullet = Instantiate(bulletObject, transform.position, transform.rotation);
        }

    }
}
