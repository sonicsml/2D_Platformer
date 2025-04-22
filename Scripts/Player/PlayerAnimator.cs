using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void IdleAnimation(bool isIdle)
    {
        _animator.SetBool("Idle", isIdle);
    }

    public void MoveAnimation(bool isMoving)
    {
        _animator.SetBool("Moving", isMoving);
    }
}
