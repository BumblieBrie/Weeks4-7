using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ClickToMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // find out if the mouse is over a UI element
        // returns true or false
        // EventSystem.current.IsPointerOverGameObject();


        // was the button pressed this frame
        // Y: set the position to be the mouse position
        if (Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }

    }
}
