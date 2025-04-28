using UnityEngine;

public class CollectVisitor : MonoBehaviour, IVisitor
{
    [SerializeField] Player _player;

    public void Visit(MedKit medkit)
    {
        Debug.Log($"������� �������.");
    }

    public void Visit(Coin coin)
    {
        coin.Collect();
        _player.AddCoin(coin.Value);
        Debug.Log($"������ �����.");
    }
}
