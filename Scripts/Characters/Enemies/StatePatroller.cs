using UnityEngine;

public class StatePatroller : BaseState
{
    private Patroller _patroller;

    public StatePatroller(StateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Вход в состояние партруль");
    }

    public override void Exit() 
    { 
        Debug.Log("Выход из состояние партруль");
    }

    public override void Update()
    {
        _patroller.Patrol();
    }
}
