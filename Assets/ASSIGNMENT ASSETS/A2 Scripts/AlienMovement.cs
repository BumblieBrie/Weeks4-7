using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float speed;
    public GameObject alien;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;

        Vector2 alienPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (alienPosition.y <= Screen.height - Screen.height)
        {
            Destroy(alien);
        }
    }
}
