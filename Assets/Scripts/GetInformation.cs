using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GetInformation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool isMouseOver;

    public TextMeshProUGUI duckDescription;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            isMouseOver = true;
            //trying to get this to set active to turn on the description for the game object
            //duckDescription.SetActive();
        }
        else
        {
            isMouseOver = false;
        }

    }
}
