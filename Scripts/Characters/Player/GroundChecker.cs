using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _groundCheckRadius = 0.5f;
    [SerializeField] private int _countResultsColliders = 1;

    private Collider2D[] _overlapResults; 

    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        _overlapResults = new Collider2D[_countResultsColliders];
    }

    private void Update()
    {
        CheckGrounded();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = IsGrounded ? Color.green : Color.red;
        Gizmos.DrawWireSphere(transform.position, _groundCheckRadius);
    }

    private void CheckGrounded()
    {
        int hitCount = Physics2D.OverlapCircleNonAlloc(
            transform.position,
            _groundCheckRadius,
            _overlapResults,
            _groundLayer
        );

        IsGrounded = hitCount > 0;
    }
}