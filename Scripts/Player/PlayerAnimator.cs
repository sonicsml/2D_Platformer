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
    
    public static class Params
    {
        public static readonly int Idle = Animator.StringToHash(nameof(Idle));
        public static readonly int Moving = Animator.StringToHash(nameof(Moving));
        public static readonly int Die = Animator.StringToHash(nameof(Die));
        public static readonly int TakeDamage = Animator.StringToHash(nameof(TakeDamage));
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
