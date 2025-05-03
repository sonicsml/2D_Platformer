using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void PlayIdleAnimation(bool isIdle)
    {
        _animator.SetBool(ParamsMover.Idle, isIdle);
    }
}
