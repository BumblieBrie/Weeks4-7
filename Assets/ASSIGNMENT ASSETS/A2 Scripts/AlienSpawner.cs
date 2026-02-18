using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AlienSpawner : MonoBehaviour
{
    private float spawnTime;
    public float spawnSpeed;
    public GameObject alienPrefab;
    public GameObject spawnedAlien;
    public List<GameObject> aliens;
    public Vector2 spawnRange;

    public Slider pHealthSlider;
    public float playerHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = pHealthSlider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        spawnRange = new Vector2(transform.position.x + Random.Range(-10f, 10f), transform.position.y);
        if (spawnTime >= spawnSpeed)
        {
            spawnTime = 0f;
            spawnedAlien = Instantiate(alienPrefab, spawnRange, quaternion.identity);
            aliens.Add(spawnedAlien);
        }

        for(int i = 0; i < aliens.Count; i++)
        {
            if (aliens[i].transform.position.y <= -4.5)
            {
                Destroy(aliens[i]);
                aliens.RemoveAt(i);
                i--;
                playerHealth--;
            }
        }
        pHealthSlider.value = playerHealth;

    }
}
