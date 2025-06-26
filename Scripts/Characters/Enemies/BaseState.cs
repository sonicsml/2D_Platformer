using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    protected StateMachine StateMachine;

    public BaseState(StateMachine stateMachine)
    {
        StateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }  
    public virtual void Update() { }
}
