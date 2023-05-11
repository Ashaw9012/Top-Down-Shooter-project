using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Search;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private Rigidbody2D _rigidBody;
    private PlayerAwareness _playerAwarenessController;
    private Vector2 _target;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _playerAwarenessController = GetComponent<PlayerAwareness>(); 
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateToTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        if (_playerAwarenessController.aware)
        {
            _target = _playerAwarenessController.directionToPlayer; 
        }
        else
        {
            _target = Vector2.zero;
        }
    }

    private void RotateToTarget()
    {
        if (_target == Vector2.zero)
        {
            return;
        }
        
        //rotates enemy
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _target); 
        //rotate rowards
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime); 
        _rigidBody.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        if (_target == Vector2.zero)
        {
            _rigidBody.velocity = Vector2.zero;
        }
        else
        {
            _rigidBody.velocity = transform.up * speed; 
        }
    }
}
