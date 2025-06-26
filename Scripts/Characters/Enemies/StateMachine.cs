using System;
using System.Collections.Generic;

public class StateMachine
{
    private BaseState StateCurrent { get; set; }

    private Dictionary<Type, BaseState> _states = new Dictionary<Type, BaseState>();

    public void AddState(BaseState state)
    {
        _states.Add(state.GetType(), state);
    }

    public void SetState<T>() where T : BaseState
    {
        var type = typeof(T);

        if (StateCurrent.GetType() == type)
        {
            return;
        }

        if (_states.TryGetValue(type, out var newState))
        {
            StateCurrent?.Exit();

            StateCurrent = newState;

            StateCurrent.Enter();
        }
    }

    public void Update()
    {
        StateCurrent?.Update();
    }
}
