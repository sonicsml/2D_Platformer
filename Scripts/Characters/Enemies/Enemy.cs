using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float _maxHealth = 1;
    [SerializeField] private float _damage = 1;
    private float _currentHealth;

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
    }

    public void Attack (Player player)
    {
        player.TakeDamage(_damage);
    }
}