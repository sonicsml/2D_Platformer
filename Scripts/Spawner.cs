using UnityEngine;

public class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private T _prefabItem;
    [SerializeField] private float _countItemsSpawn = 3;

    public virtual void Start()
    {
        ItemsSpawn();
    }

    private void OnValidate()
    {
        _countItemsSpawn = Mathf.Clamp(_countItemsSpawn, 0, _spawnPoints.Length);
    }

    public virtual void ItemsSpawn()
    {
        for (var i = 0; i < _countItemsSpawn; i++)
        {
            ItemsSpawn(_spawnPoints[i].position);
        }
    }

    public virtual void ItemsSpawn(Vector3 position)
    {
        T item = Instantiate(_prefabItem, position, Quaternion.identity);
        OnSpawn(item);
    }

    protected virtual void OnSpawn(T item) { }
}
