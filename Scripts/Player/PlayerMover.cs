using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpForce = 11f;
    [SerializeField] private float _gravityScale = 2f;
    [SerializeField] private float _upgradeGravityScale = 3f;

    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private Animator _animator;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _moveVector;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Idle();
        Move();
        Rotate();

        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGrounded)
        {
            Jump();
        }

        if (_groundChecker.IsGrounded == false && _rigidbody2D.linearVelocity.y < 0)
        {
            _rigidbody2D.gravityScale = _upgradeGravityScale;
        }
        else
        {
            _rigidbody2D.gravityScale = _gravityScale;
        }
    }

    private void Idle()
    {
        float moveInput = Input.GetAxis("Horizontal");
        bool isIdle = Mathf.Abs(moveInput) < 0.1f && _groundChecker.IsGrounded;

        _animator.SetBool("Idle", isIdle);
        Debug.Log($"Idle() Idle {moveInput}, isIdle {isIdle}");
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        bool isMoving = Math.Abs(moveInput) > 0.1f;

        Debug.Log($"Move() move {moveInput}, isMoving {isMoving}");

        _animator.SetBool("Moving", isMoving);
        _moveVector = new Vector2(moveInput * _speed, 0f);
        transform.Translate(_moveVector * Time.deltaTime);
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void Rotate()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0)
        {
            spriteRenderer.flipX = moveInput < 0;
        }
    }
}
