using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Healthdisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite emptyHealth;
    public Sprite fullHealth;
    public Image[] hearts;

    public Playerhealth playerHealth; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.health; 
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHealth; 
            }
            else
            {
                hearts[i].sprite = emptyHealth; 
            }
            if (i < maxHealth)
            {
                hearts[i].enabled = true; 
            }
            else
            {
                hearts[i].enabled = false; 
            }
        }
    }
}
