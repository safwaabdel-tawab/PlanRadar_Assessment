using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    public float perspectiveZoomSpeed = 0.5f; // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f; // The rate of change of the orthographic size in orthographic mode.

    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;

    private Vector3 previousPosition;
    void Update()
    {
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // If the camera is orthographic...
            if (camera.orthographic)
            {
                // ... change the orthographic size based on the change in distance between the touches.
                camera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

                // Make sure the orthographic size never drops below zero.
                camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
            }
            else
            {
                // Otherwise change the field of view based on the change in distance between the touches.
                camera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

                // Clamp the field of view to make sure it's between 0 and 180.
                camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 0.1f, 179.9f);
            }
        }
        else if (Input.touchCount == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                previousPosition = camera.ScreenToViewportPoint(Input.mousePosition);
            }

            if (Input.GetMouseButton(0))
            {
                Vector3 direction = previousPosition - camera.ScreenToViewportPoint(Input.mousePosition);

                // camera.transform.position = new Vector3();
                camera.transform.position = target.position;
                camera.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
                camera.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
                camera.transform.Translate(new Vector3(0, 0, -160));

                previousPosition = camera.ScreenToViewportPoint(Input.mousePosition);

            }
        }
    }
}