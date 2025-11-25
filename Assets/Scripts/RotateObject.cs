using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private float rotationSpeed = 5f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate(-touchDeltaPosition.y * rotationSpeed, touchDeltaPosition.x * rotationSpeed, 0);
        }
    }
}