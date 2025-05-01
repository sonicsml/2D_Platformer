using UnityEngine;

public class Coin : MonoBehaviour, ICollectible
{
    [SerializeField] private AudioClip _collectSound;
    [field: SerializeField] public float Value { get; private set; } = 1f;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);

        if (_collectSound != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
        }
    }
}