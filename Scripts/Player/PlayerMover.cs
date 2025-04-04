using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpForce = 12f;
    [SerializeField] private float _gravityScale = 5f;
    [SerializeField] private GroundChecker _groundChecker;

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
        Move();
        Rotate();

        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGrounded)
        {
            Jump();
        }
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

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
