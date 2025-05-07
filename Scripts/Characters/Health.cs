using UnityEngine;

public class Health : MonoBehaviour
{
    public int Healthy {  get; private set; }
/*  [SerializeField] private float _maxHealth;
    [SerializeField] private float _invulnerabilityTime = 1f;

    [SerializeField] private AudioClip _damageSound;

    private float _currentHeadth;
    private float _invulnerabilityTimer;

    private bool _isInvulnerability;
    private bool _isDie;
    private bool _isTakeDamage;

    private void Awake()
    {
        _currentHeadth = _maxHealth;
    }

    private void TakeDamage(float damage)
    {
        if (_isInvulnerability)
        {
            return;
        }

        _currentHeadth -= damage;
        _animator.TakeDamageAnimator(_isTakeDamage);
        AudioSource.PlayClipAtPoint(_damageSound, transform.position);
        
        if (_currentHeadth <= 0)
        {
            Die();
        }
        else
        {
            _isInvulnerability = true;
            _invulnerabilityTimer = _invulnerabilityTime;
        }
    }

    private void Die()
    {
        _animator.DieAnimation(_isDie);
        Destroy(gameObject);
    }*/
}
