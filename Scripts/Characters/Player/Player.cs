using System;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private float _maxHealth = 3;
    [SerializeField] private float _damage = 1;

    public event Action HealthChanged;

    private float _currentHealth;
    private float _coins = 0;

    public void HandleMedkitCollected(float medkitValue)
    {
        if (_currentHealth > _maxHealth)
        {
            _currentHealth += medkitValue;
        }
    }

    public void HandleCoinCollected(float coinValue)
    {
        _coins += coinValue;
    }

    public void TakeDamage(float damage) 
    {
        _currentHealth -= Math.Max(damage, 0); ;
    }

    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(_damage);
    }

    public float Health 
        { 
        get => _currentHealth;
        set 
        {
            if (value >= 0 && value <= _maxHealth)
            {
                _currentHealth = value;
                
                if (HealthChanged != null)
                {
                    HealthChanged.Invoke();
                }
            }
        } 
    }
}