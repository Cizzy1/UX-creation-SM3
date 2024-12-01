using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D CursorText;
    CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(CursorText, hotSpot, cursorMode);
    }
}
