using UnityEngine;

public class EnemyGroundChecker : MonoBehaviour
{
    [SerializeField] private Transform _raycastOrigin;
    [SerializeField] private float _rayDistance = 0.5f;
    [SerializeField] private BoxCollider2D _collider;

    public bool CheckGroundAhead(LayerMask groundLayer)
    {
        Vector2 direction = Vector2.down;

        Debug.DrawRay(_raycastOrigin.position, direction, Color.red);

        RaycastHit2D checkGround = Physics2D.BoxCast(
            _raycastOrigin.position,
            _collider.size,
            0f,
            Vector2.down,
            _rayDistance,
            groundLayer
        );

        return checkGround.collider == null;
    }
}
