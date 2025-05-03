using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 3;

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
}