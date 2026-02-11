using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class FollowTheMouse : MonoBehaviour
{
    public Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;

        transform.right = -direction;

        Debug.Log(mousePos);
    }
}
