using UnityEngine;

public class Player : MonoBehaviour
{
    private float _coins = 0;
    private Health _maxHealth;

/*    public void AddCoin(float value)
    {
        _coins += value;
    }

    public void Healing(float value)
    {

    }*/


    public void Healing(float amount) => Debug.Log($"Player healed: +{amount} HP");
    public void AddCoin(float value) => Debug.Log($"Coin added: +{value} gold");
}
