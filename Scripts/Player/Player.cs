using UnityEngine;

public class Player : MonoBehaviour
{
    private float _coins = 0;

    public void AddCoin(float value)
    {
        _coins += value;
    }
}
