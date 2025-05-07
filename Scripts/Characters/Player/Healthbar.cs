using NUnit.Framework;
using UnityEngine;

public class Healthbar : MonoBehaviour, IObserver
{
    [SerializeField] private List<Image> _hearts;
    [SerializeField] private Player _player;

    private void UpdateUI(float health) { }

    public void HealthChanged()
    {
        var health = _player.Health;
        UpdateUI(health); 
    }
}
