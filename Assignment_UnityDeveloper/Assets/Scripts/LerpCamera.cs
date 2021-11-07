using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour
{
    public Transform InitialPos;

    public float timeStartedLerping;
    public float lerpTime_Pos;
    public float lerpTime_Rotat;

    private Vector3 targetPos;
    private Vector3 startPos;

    private Quaternion targetRotat;
    private Quaternion startRotat;

    private bool shouldLerp = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = InitialPos.position;
        targetRotat = InitialPos.rotation;

        //endPosition = new Vector3(InitialPos.position.x, InitialPos.position.y, InitialPos.position.z);
        //StartLerping();
    }

    public void StartLerping()
    {
        startPos = transform.position;
        startRotat = transform.rotation;

        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {
            transform.position = Lerp_Pos(startPos, targetPos, timeStartedLerping, lerpTime_Pos);
            transform.rotation = Lerp_Rotation(startRotat, targetRotat, timeStartedLerping, lerpTime_Pos);

            if ((transform.position == targetPos) &&
                (transform.rotation == targetRotat)) 
                shouldLerp = false;
        }
    }

    public Vector3 Lerp_Pos(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
    
    public Quaternion Lerp_Rotation(Quaternion start, Quaternion end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Quaternion.Lerp(start, end, percentageComplete);

        return result;
    }
}
