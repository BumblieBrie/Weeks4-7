using UnityEngine;
using UnityEngine.UIElements;

public class Collision : MonoBehaviour
{
    public GameObject laser;
    public AlienSpawner alienScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //access the script for the list of aliens
        //loop through the list of aliens to check their position
        //calculate the distance between the laser's position and compare it to each aliens position
        //if that distance is less than 1, rotate then destroy the alien and remove it from the list
        //not sure why this ism't working :((

        for (int i = 0; i < alienScript.aliens.Count; i++)
        {
            float distance = Vector2.Distance(laser.transform.position, alienScript.aliens[i].transform.position);
            if (distance < 1f)
            {
                Vector3 newRotation = alienScript.aliens[i].transform.eulerAngles;
                newRotation.z += 10 * Time.deltaTime;
                transform.eulerAngles = newRotation;

                Destroy(alienScript.aliens[i]);
                alienScript.aliens.RemoveAt(i);
            }
        }
        
    }
}
