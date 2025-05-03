using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(InputReader))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpForce = 11f;
    [SerializeField] private float _gravityScale = 2f;
    [SerializeField] private float _increaseGravity = 3f;

    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private PlayerAnimator _playerAnimator;
    [SerializeField] private Rotator _flip;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _moveVector;
    private InputReader _inputReader;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _inputReader = GetComponent<InputReader>();
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
            _rigidbody2D.gravityScale = _increaseGravity;
        }
        else
        {
            _rigidbody2D.gravityScale = _gravityScale;
        }
    }

    private void Idle()
    {
        float moveInput = _inputReader.GetHorizontalInput();
        bool isIdle = Mathf.Abs(moveInput) < 0 && _groundChecker.IsGrounded;

        _playerAnimator.PlayIdleAnimation(isIdle);
    }
    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void Move()
    {
        float moveInput = _inputReader.GetHorizontalInput();
        bool isMoving = Math.Abs(moveInput) > 0;

        _playerAnimator.PlayMoveAnimation(isMoving);
        _moveVector = new Vector2(moveInput * _speed, 0f);
        transform.position += (Vector3)_inputReader.Direction * (_speed * Time.deltaTime);
    }

    private void Rotate()
    {
        Vector3 moveInput = _inputReader.Direction;

        _flip.Rotate(moveInput.x);
    }
}
