using UnityEngine;

public class AlienSpriteChanger : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] aliens;
    public int randomAlien;

    public bool alienIsYellow = false;
    public bool alienIsBlue = false;
    public bool alienIsPurple = false;
    public bool alienIsRed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //set up some options for the aliens colour, don't forget to put the sprites in in the inspector
    //get some bools ready to compare with the colour of the laser
    //set each new alien to a random sprite out of the list
    
    void PickARandomSprite()
    {
        randomAlien = Random.Range(0, aliens.Length);

        if(randomAlien == 0)
        {
            sr.sprite = aliens[0];
            alienIsYellow = true;
        }
        else if(randomAlien == 1)
        {
            sr.sprite = aliens[1];
            alienIsBlue = true;
        }
        else if(randomAlien == 2)
        {
            sr.sprite = aliens[2];
            alienIsPurple = true;
        }
        else if(randomAlien == 3)
        {
            sr.sprite = aliens[3];
            alienIsRed = true;
        }
    }
}
