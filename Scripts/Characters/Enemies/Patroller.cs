using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private EnemyGroundChecker _groundChecker;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private EnemyMover _mover;

    [SerializeField] private float _rayDistance = 0.55f;
    
    private bool _movingLeft;

    public void Patrol()
    {
        if (WallAhaed() || _groundChecker.GroundAhead(_groundLayer))
        {
            _mover.Rotate();
        }

        _mover.Move();
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
}
