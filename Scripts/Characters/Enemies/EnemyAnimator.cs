using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void IdleAnimation(bool isIdle)
    {
        _animator.SetBool(Params.Idle, isIdle);
    }
}
