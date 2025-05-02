using System.Runtime.InteropServices;
using UnityEngine;

public class Collector : MonoBehaviour, IVisitor
{
    [SerializeField] Player _player;

    public void Visit(MedKit medkit)
    { 
        _player.Healing(medkit.Value);
        Debug.Log($"Аптечка собрана.");
    }

    public void Visit(Coin coin)
    {
        _player.AddCoin(coin.Value);
        Debug.Log($"Собран алмаз.");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out ICollectible collectible)) 
        {
            collectible.Accept(this);
        }
    }
}