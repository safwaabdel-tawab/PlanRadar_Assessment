using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour
{
    public Transform InitialPos;

    public float timeStartedLerping;
    public float lerpTime_Pos;
    public float lerpTime_Rotat;

    private Vector3 endPosition;
    private Vector3 startPosition;
    private bool shouldLerp = false;

    // Start is called before the first frame update
    void Start()
    {
        endPosition = new Vector3(InitialPos.position.x, InitialPos.position.y, InitialPos.position.z);
        //StartLerping();
    }

    public void StartLerping()
    {
        startPosition = transform.position;
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {
            transform.position = Lerp(startPosition, endPosition, timeStartedLerping, lerpTime_Pos);

            if (transform.position == endPosition) shouldLerp = false;
        }
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
