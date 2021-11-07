using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;

    private Vector3 previousPosition;

    // Update is called once per frame
    void Update()  //add delta for the finger if it is still don't move
    {
        if (Input.touchCount == 1)
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
