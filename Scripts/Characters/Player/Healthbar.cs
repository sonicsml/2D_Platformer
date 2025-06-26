using NUnit.Framework;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void UpdateUI(float health) { }

    private void HealthChanged()
    {
        var health = _player.Health;
        UpdateUI(health); 
    }

    private void OnEnable()
    {
        _player.HealthChanged += HealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= HealthChanged;
    }
}
