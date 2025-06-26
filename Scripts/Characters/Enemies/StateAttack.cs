using UnityEngine;

public class StateAttack : BaseState
{
    public StateAttack(StateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Вход в состояние атаки");
    }

    public override void Exit()
    {
        Debug.Log("Выход из состояние атаки");
    }

    public override void Update()
    {
        Debug.Log("Если игрок в пределах досигаемости, атакуем");
    }
}
