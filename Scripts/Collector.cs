using UnityEngine;

public class Collector : MonoBehaviour
{
    /*public event Action<float> OnCollected;*/
    [SerializeField] Player _player;

    private void OnTriggerEnter2D(Collider2D other)
    {
 /*       OnCollected?.Invoke(_value);*/
        if (other.TryGetComponent(out Coin coin))
        {
            coin.Collect();
            _player.AddCoin(coin.Value);
        }
    }
}