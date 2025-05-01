using UnityEngine;

public class ParamsMover
{
    public static readonly int Idle = Animator.StringToHash(nameof(Idle));
    public static readonly int Moving = Animator.StringToHash(nameof(Moving));
    public static readonly int Die = Animator.StringToHash(nameof(Die));
    public static readonly int TakeDamage = Animator.StringToHash(nameof(TakeDamage));
}
