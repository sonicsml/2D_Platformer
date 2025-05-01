using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private EnemyAnimator _enemyAnimator;

    [SerializeField] private float _speed = 2f;
    [SerializeField] private Turn _flip;
    [SerializeField] private Patroller _patroller;

    private bool _isMoving;

    private void Awake()
    {
        Rotate();
    }

    private void Update()
    {
        _patroller.Patrol();
    }

    public void Move()
    {
        _enemyAnimator.IdleAnimation(_isMoving);
        transform.Translate(_speed * Vector3.left * Time.deltaTime);
    }

    public void Rotate()
    {
        Vector3 forwardDirection = transform.forward;

        _flip.Rotate(forwardDirection.z);

        transform.forward = -transform.forward;
    }
}
