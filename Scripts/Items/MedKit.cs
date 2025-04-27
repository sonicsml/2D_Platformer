using UnityEngine;

public class MedKit : MonoBehaviour
{
    [SerializeField] private AudioClip _collectSound;
    [field: SerializeField] public float Value { get; private set; } = 1f;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Collect()
    {
        if (_collectSound != null)
        {
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);
        }

        Destroy(gameObject);
    }
}
