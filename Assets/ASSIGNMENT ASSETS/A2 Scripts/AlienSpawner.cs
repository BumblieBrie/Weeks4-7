using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class AlienSpawner : MonoBehaviour
{
    private float spawnTime;
    public float spawnSpeed;
    public GameObject alienPrefab;
    public Vector2 spawnRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        spawnRange = new Vector2(transform.position.x + Random.Range(-10f, 10f), transform.position.y);
        if (spawnTime >= spawnSpeed)
        {
            spawnTime = 0f;
            Instantiate(alienPrefab, spawnRange, quaternion.identity);
        }
    }
}
