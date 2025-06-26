using UnityEngine;

public class EnemyPlayerChecker : MonoBehaviour
{    
    [SerializeField] private float _raycastDistance = 0.5f;
    [SerializeField] private LayerMask _playerLayerMask;
    [SerializeField] private BoxCollider2D _collider;

    private void Update()
    {
        CheckPlayerUp();
    }

    private void CheckPlayerUp()
    {
        Debug.DrawRay(transform.position, Vector3.up, Color.yellow);
        
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            Vector3.up,
            _raycastDistance,
            _playerLayerMask
            );
/*        if (hit.collider != null)
        {

            if (hit.collider.TryGetComponent(out Player player))
            {
                Debug.Log("игрок сверху");
                EnemySpawner.DestroyEnemy();
            }
        }*/
    }
}
