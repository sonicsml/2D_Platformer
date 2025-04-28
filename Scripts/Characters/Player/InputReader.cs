using UnityEngine;

public class InputReader : MonoBehaviour
{
    public const string Horizontal = "Horizontal";

    private const KeyCode JumpButton = KeyCode.Space;

    public Vector2 Direction { get; private set; }

    private void Update()
    {
        Direction = new Vector2(GetHorizontalInput(), 0);
    }

    public float GetHorizontalInput()
    {
        return Input.GetAxis(Horizontal);
    }

    public bool IsJumpPressed()
    {
        return Input.GetKeyDown(JumpButton);
    }
}
