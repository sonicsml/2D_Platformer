using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private EnemyGroundChecker _groundChecker;
    [SerializeField] private EnemyAnimator _enemyAnimator;
    [SerializeField] private LayerMask _groundLayer;

    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _rayDistance = 0.55f;
    [SerializeField] private float _rotationOne = 180f;
    [SerializeField] private float _rotationtwo = 0f;

    private SpriteRenderer _spriteRenderer;

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
        _movingLeft = !_movingLeft;
        transform.rotation = _movingLeft ? Quaternion.Euler(0,_rotationOne,0) : Quaternion.Euler(0, _rotationtwo, 0);
    }
}
