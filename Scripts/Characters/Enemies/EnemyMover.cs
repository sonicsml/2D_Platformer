using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private EnemyGroundChecker _groundChecker;
    [SerializeField] private EnemyAnimator _enemyAnimator;
    [SerializeField] private LayerMask _groundLayer;

    [SerializeField] private float _rayDistance = 0.55f;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Flip _flip;

    private SpriteRenderer _spriteRenderer;
    private InputReader _inputReader;

    private bool _movingLeft;
    private bool _isMoving;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Rotate();
    }

    private void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        if (WallAhaed() || _groundChecker.GroundAhead(_groundLayer))
        {
            Rotate();
        }

        Move();
    }

    private bool WallAhaed()
    {
        Vector2 direction;

        if (_movingLeft)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }

        Debug.DrawRay(transform.position, direction, Color.blue);

        RaycastHit2D wallHit = Physics2D.Raycast(
            transform.position,
            direction,
            _rayDistance,
            _groundLayer
        );

        return wallHit.collider != null;
    }

    private void Move()
    {
        _enemyAnimator.IdleAnimation(_isMoving);
        transform.Translate(_speed * Vector3.left * Time.deltaTime);
    }

    private void Rotate()
    {
        Vector3 forwardDirection = transform.forward;

        _flip.Rotate(forwardDirection.z);

        transform.forward = -transform.forward;
    }
}
