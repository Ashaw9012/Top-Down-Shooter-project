using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    public int health;
    public int maxHealth; 
    
    
    void Start()
    {
        health = maxHealth; 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(5);
        }
    }
}
