using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _collectSound;

    [field: SerializeField] public float Value { get; private set; } = 1f;

    public void Collect()
    {
        if (_collectSound != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
        }

        Destroy(gameObject);
    }
}
