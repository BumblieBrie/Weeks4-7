using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawnerr : MonoBehaviour
{
    public GameObject tankPrefab; // Reference to the tank prefab
    public GameObject spawnedTank; // 

    public int howManyTanks = 0;

    public Move tankScript;
    //public SpriteRenderer tankSR;

    public List<GameObject> tanks;

    public Transform barrel;

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
            //tankSR = spawnedTank.GetComponent<SpriteRenderer>();

            tankScript = spawnedTank.GetComponent<Move>();

            howManyTanks++;
            //tankScript.speed = howManyTanks;

            //how to get at the sprite renderer of child sprite, make it on the script attached to the component and then inspect the prefab
            tankScript.body.color = Random.ColorHSV();

            tanks.Add(spawnedTank);

            
        }

        // loop throguh the list of tanks: these are GameObjects
        // get each tanks transform and compare that to the barrel
        // is the tank at the same position as the barrel?

        if (Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            tanks.Remove(spawnedTank);
            Destroy(spawnedTank);
        }

        for (int i = tanks.Count - 1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if (distance < 0.5f)
            {
                // remove the tank from the list and destroy it when over the barrel
                Debug.Log("Exploded tank at index " + i);

                GameObject tank = tanks[i];
                tanks.Remove(tank);
                Destroy(tank);
            }
        }
        /*
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //instantiate a Transform: make it appear as a child of this transform
            Instantiate(tankPrefab, transform);
        }*/
    }
}
