using UnityEngine;

public class Toggle : MonoBehaviour

{
    
    public void ToggleMoon()
    {
        // if the game object is active, set it to inactive
        // else set it to active

        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //} else if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}

        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

}
