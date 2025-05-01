using UnityEngine;

public class Player : MonoBehaviour
{
    private float _coins = 0;
    private Health _maxHealth;

    public void Healing(float amount) => Debug.Log($"Игрок излечен на: +{amount}");
    public void AddCoin(float value) => Debug.Log($"Собрано алмазов: +{value}");
}