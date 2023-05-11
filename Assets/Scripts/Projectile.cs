using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //The direction
    public Vector2 direction;
    //bullet speed
    public float speed = 5f;
    //bullet damage
    public int damage; 
    public Enemyhealth enemyHealth;
    public void Start()
    {
        //move the bullet
        GetComponent<Rigidbody2D>().velocity = direction * speed; 
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {
        Debug.Log("collision");
        Destroy(gameObject);
        
        if (collison.gameObject.tag == "Enemy")
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}
