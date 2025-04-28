using UnityEngine;

public class CollectVisitor : MonoBehaviour, IVisitor
{
    public void Visit(MedKit medkit)
    {
        Debug.Log($"Аптечка собрана.");
    }

    public void Visit(Coin coin)
    {
        Debug.Log($"Собран алмаз.");
    }
}
