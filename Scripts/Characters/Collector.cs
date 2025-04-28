using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] Player _player;

/*    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            coin.Collect();
            _player.AddCoin(coin.Value);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();

        if (collectible != null)
        {
            var visitor = new CollectVisitor();
            collectible.Accept(visitor);
        }
    }
}