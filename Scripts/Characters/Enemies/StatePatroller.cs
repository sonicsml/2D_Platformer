using UnityEngine;

public class StatePatroller : BaseState
{
    private Patroller _patroller;

    public StatePatroller(StateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("���� � ��������� ��������");
    }

    public override void Exit() 
    { 
        Debug.Log("����� �� ��������� ��������");
    }

    public override void Update()
    {
        _patroller.Patrol();
    }
}
