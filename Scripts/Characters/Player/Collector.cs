using UnityEngine;

public class Collector : MonoBehaviour, IVisitor
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out ICollectible collectible)) 
        {
            collectible.Accept(this);
        }
    }

    public void Collect(Coin coin)
    {
        _player.HandleCoinCollected(coin.Value);
        Debug.Log($"Гем подобран.");
    }

    public void Collect(MedKit medkit)
    {
        _player.HandleMedkitCollected(medkit.Value);
        Debug.Log($"Аптечка подобрана.");
    }
}