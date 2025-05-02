using System;
using UnityEngine;

public abstract class BaseItem : MonoBehaviour, IItem
{
    [SerializeField] private AudioClip _collectSound;
    [field: SerializeField] public float Value { get; private set; } = 1f;

    public static Action<float> OnItemCollected;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        Pickup();
        gameObject.SetActive(false);
        PlayCollectSound();
    }

    public void PlayCollectSound()
    {
        if (_collectSound != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
        }
    }

    public void Pickup() 
    {
        OnItemCollected?.Invoke(Value);
        Use();
    }

    public abstract void Use();
}
