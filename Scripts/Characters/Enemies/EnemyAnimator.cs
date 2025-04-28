using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void IdleAnimation(bool isIdle)
    {
        _animator.SetBool("Idle", isIdle);
    }
}
