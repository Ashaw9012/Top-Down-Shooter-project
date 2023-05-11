using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public bool aware { get; private set; }
    public Vector2 directionToPlayer { get; private set; }

    [SerializeField] private float playerAwarenessDistance;

    private Transform _player;

    private void Awake()
    {
        _player = FindObjectOfType<TopDownCharacterController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        //where the enemy is to the player
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        //retains direction, magnitude = 1
        directionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= playerAwarenessDistance)
        {
            aware = true; 
        }
        else
        {
            {
                aware = false; 
            }
        }
    }
}
