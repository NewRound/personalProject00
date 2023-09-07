using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Transform aimPivot;

    private PPCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<PPCharacterController>();
    }


    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateBody(newAimDirection);
    }

    private void RotateBody(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

}
