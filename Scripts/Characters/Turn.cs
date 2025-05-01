using UnityEngine;

public class Turn : MonoBehaviour
{
    private const float RotationOne = 180f;

    public void Rotate(float direction)
    {
        if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
        }
        else
        if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(0, RotationOne, 0);
        }
    }
}
