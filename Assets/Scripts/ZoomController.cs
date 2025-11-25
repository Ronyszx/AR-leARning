using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ZoomController : MonoBehaviour
{
    [SerializeField] private ARSessionOrigin arSessionOrigin;
    [SerializeField] private float zoomSpeed = 0.5f;

    private float startingDistance = 0f;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                startingDistance = Vector2.Distance(touchZero.position, touchOne.position);
            }
            else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved)
            {
                float distance = Vector2.Distance(touchZero.position, touchOne.position);
                float delta = (distance - startingDistance) * zoomSpeed;

                Vector3 cameraPos = arSessionOrigin.camera.transform.localPosition;
                cameraPos.z += delta;
                arSessionOrigin.camera.transform.localPosition = cameraPos;

                startingDistance = distance;
            }
        }
    }
}
