using UnityEngine;

public class StateAttack : BaseState
{
    public StateAttack(StateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("���� � ��������� �����");
    }

    public override void Exit()
    {
        Debug.Log("����� �� ��������� �����");
    }

    public override void Update()
    {
        Debug.Log("���� ����� � �������� ������������, �������");
    }
}
