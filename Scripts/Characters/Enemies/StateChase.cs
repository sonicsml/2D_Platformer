using UnityEngine;

public class StateChase : BaseState
{
    private Player _player;
    private float _detectionRange = 5f;
    private float _speed = 3f;

    private EnemyMover _enemyMover;

    public StateChase(StateMachine stateMachine) : base(stateMachine) { }

    public override void Update()
    {
        Debug.Log("Преследование");
    }

    private bool DetectPlayer()
    {
        if (Vector2.Distance(transform.position, _player.transform.position) > _detectionRange)
        {
            return false;
        }

        return true;
    }

    private void ChasePlayer()
    {
        /*Vector2 direction = (_player.transform.position - transform.position).normalized;*/
        /*transform.Translate(direction * _enemyMover._speed * Time.deltaTime);*/
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        
        /*if (_player != null )
        {
            Gizmos.DrawLine(transform.position, _player.transform.position);
        }*/
    }
}
