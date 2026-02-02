using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawnerr : MonoBehaviour
{
    public GameObject tankPrefab; // Reference to the tank prefab
    public GameObject spawnedTank; // 

    public int howManyTanks = 0;

    public Move tankScript;
    public SpriteRenderer tankSR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Instantiate a prefab: make this one appear
            //Instantiate a prefab, a Vector2 or Vector3, a quaternion: make it appear at this position and rotation
            //Instantiate(tankPrefab);
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            Vector2 spawnPosition = Random.insideUnitCircle * 3f;

            //Quaternion.identity means "no rotation" which is the same as Euler angles (0,0,0)
            spawnedTank = Instantiate(tankPrefab, spawnPosition, Quaternion.identity);
            tankSR = spawnedTank.GetComponent<SpriteRenderer>();

            tankScript = spawnedTank.GetComponent<Move>();

            howManyTanks++;
            tankScript.speed = howManyTanks;
        }
        /*
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //instantiate a Transform: make it appear as a child of this transform
            Instantiate(tankPrefab, transform);
        }*/
    }
}
