using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Start()
    {   
        if (_animator == null)
        {
            _animator = GetComponent<Animator>();
        }
    }

    public void IdleAnimation(bool isIdle)
    {
        _animator.SetBool(ParamsMover.Idle, isIdle);
    }

    public void MoveAnimation(bool isMoving)
    {
        _animator.SetBool(ParamsMover.Moving, isMoving);
    }

    public void DieAnimation(bool isDie)
    {
        _animator.SetBool(ParamsMover.Die, isDie);
    }

    public void TakeDamageAnimator(bool isTakeDamage)
    {
        _animator.SetBool(ParamsMover.TakeDamage, isTakeDamage);
    }
}
