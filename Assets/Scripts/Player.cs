using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _walkSpeed;

    [SerializeField]
    private float _jumpForce;

    private Animator _anim;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CheckJump();
    }

    private void FixedUpdate()
    {
        CheckMove();
    }

    private void CheckMove()
    {
        float moveDir = Input.GetAxis("Horizontal");
        transform.Translate(moveDir * _walkSpeed * Time.deltaTime, 0, 0, Space.World);
    }

    private void CheckJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, 0);
        _rb.AddForce(Vector2.up * _jumpForce);
    }
}
