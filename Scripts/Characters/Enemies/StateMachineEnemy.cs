using UnityEngine;

public class StateMachineEnemy : MonoBehaviour
{
    private StateMachine _stateMachine;

    private void Start()
    {
        _stateMachine = new StateMachine();

        _stateMachine.AddState(new StatePatroller(_stateMachine));
        _stateMachine.AddState(new StateChase(_stateMachine));
        _stateMachine.AddState(new StateAttack(_stateMachine));
    }
}
