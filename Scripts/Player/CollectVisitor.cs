using UnityEngine;

public class CollectVisitor : MonoBehaviour, IVisitor
{
    public void Visit(MedKit medkit)
    {
        Debug.Log($"������� �������.");
    }

    public void Visit(Coin coin)
    {
        Debug.Log($"������ �����.");
    }
}
