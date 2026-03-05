using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static bool IsTouchInput()
    {
        return Input.touchCount > 0;
    }

    public static Vector2 GetTouchPosition()
    {
        return Input.GetTouch(0).position;
    }

    public static bool IsMouseInput()
    {
        return Input.GetMouseButton(0);
    }

    public static Vector2 GetMousePosition()
    {
        return Input.mousePosition;
    }

    void Update()
    {
        if (IsTouchInput())
        {
            Vector2 touchPos = GetTouchPosition();
            // Handle touch input logic
            Debug.Log("Touch Position: " + touchPos);
        }
        else if (IsMouseInput())
        {
            Vector2 mousePos = GetMousePosition();
            // Handle mouse input logic
            Debug.Log("Mouse Position: " + mousePos);
        }
    }
}