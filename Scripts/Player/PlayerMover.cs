using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    private const float RotationOne = 180f;
    private const float Rotationtwo = 0f;

    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpForce = 11f;
    [SerializeField] private float _gravityScale = 2f;
    [SerializeField] private float _upgradeGravityScale = 3f;

    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private PlayerAnimator _playerAnimator;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _moveVector;
    private InputReader _inputReader;
    private bool _movingLeft;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _inputReader = GetComponent<InputReader>();
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

        if (_inputReader.IsJumpPressed() && _groundChecker.IsGrounded)
        {
            Jump();
        }

        UpdateGravity();
    }

    private void UpdateGravity()
    {
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
        float moveInput = _inputReader.GetHorizontalInput();
        bool isIdle = Mathf.Abs(moveInput) < 0.1f && _groundChecker.IsGrounded;

        _playerAnimator.IdleAnimation(isIdle);
    }
    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void Move()
    {
        float moveInput = _inputReader.GetHorizontalInput();
        bool isMoving = Math.Abs(moveInput) > 0.1f;

        _playerAnimator.MoveAnimation(isMoving);
        _moveVector = new Vector2(moveInput * _speed, 0f);
        transform.position += (Vector3) _inputReader.Direction * (_speed * Time.deltaTime);
    }

    private void Rotate()
    {
        Vector2 moveInput = _inputReader.Direction;

        if (moveInput.x > 0) 
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
        } 
        else
        if (moveInput.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, RotationOne, 0);
        }
    }
}
