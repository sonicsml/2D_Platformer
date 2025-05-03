using UnityEngine;

public abstract class BaseItem : MonoBehaviour, ICollectible
{
    [SerializeField] private AudioClip _collectSound;
    [field: SerializeField] public float Value { get; private set; } = 1f;

    public void Accept(IVisitor visitor)
    {
        OnAccept(visitor);
        PlayCollectSound();
    }

    public void PlayCollectSound()
    {
        if (_collectSound != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
        }
    }

    protected abstract void OnAccept(IVisitor visitor);
}
