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

    public void Start()
    {
        //move the bullet
        GetComponent<Rigidbody2D>().velocity = direction * speed; 
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {
        Debug.Log("collision");
        Destroy(gameObject);
    }
}
