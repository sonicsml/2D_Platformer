using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const KeyCode JumpButton = KeyCode.Space;

    public Vector2 Direction { get; private set; }

    private void Update()
    {
        Direction = new Vector2(GetHorizontalInput(), 0);
    }

    public float GetHorizontalInput()
    {
        return Input.GetAxis(HorizontalAxis);
    }

    public bool IsJumpPressed()
    {
        return Input.GetKeyDown(JumpButton);
    }
}
