using UnityEngine;

public class CollectVisitor : MonoBehaviour, IVisitor
{
    [SerializeField] Player _player;

    public void Visit(MedKit medkit)
    {
        Debug.Log($"Аптечка собрана.");
    }

    public void Visit(Coin coin)
    {
        coin.Collect();
        _player.AddCoin(coin.Value);
        Debug.Log($"Собран алмаз.");
    }
}
