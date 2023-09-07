using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPMovement : MonoBehaviour
{
    private PPCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    [SerializeField]
    public int speed = 5;

    private void Awake()
    {
        _controller = GetComponent<PPCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }


    // update와 다르게 물리적인 처리를 하는 부분.
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        _rigidbody.velocity = direction;
    }
}
