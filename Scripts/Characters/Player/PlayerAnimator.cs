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
        _animator.SetBool(Params.Idle, isIdle);
    }

    public void MoveAnimation(bool isMoving)
    {
        _animator.SetBool(Params.Moving, isMoving);
    }

    public void DieAnimation(bool isDie)
    {
        _animator.SetBool(Params.Die, isDie);
    }

    public void TakeDamageAnimator(bool isTakeDamage)
    {
        _animator.SetBool(Params.TakeDamage, isTakeDamage);
    }
}
