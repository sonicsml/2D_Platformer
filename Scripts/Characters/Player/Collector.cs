using UnityEngine;

public class Collector : MonoBehaviour, IVisitor
{
    [SerializeField] private Player _player;

    public void Awake()
    {
        _player = GetComponent<Player>();
    }

    public void Visit(IItem item)
    {
        Debug.Log($"Предмет подобран.");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out ICollectible collectible)) 
        {
            collectible.Accept(this);
        }
    }
}