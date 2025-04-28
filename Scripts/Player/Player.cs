using Unity.Properties;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _coins = 0;

    public void AddCoin(float value)
    {
        _coins += value;
    }

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
