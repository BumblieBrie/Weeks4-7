using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            transform.position -= transform.right * Time.deltaTime;
        } 
        else if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            transform.position += transform.right * Time.deltaTime;
        }
    }
}
