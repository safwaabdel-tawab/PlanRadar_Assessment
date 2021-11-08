using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checking downloading process.
/// </summary>
public class DownloadingModel : MonoBehaviour
{
    [SerializeField]
    GameEvent downloadFinishedEvent;

    private bool _downloadIsFinished;
    public bool DownloadIsFinished
    {
        set
        {
            _downloadIsFinished = value;
            if (value) downloadFinishedEvent.Raise();
        }
        get
        {
            return _downloadIsFinished;
        }
    }
    void Start()
    {
        DownloadIsFinished = false;
        StartCoroutine(StillDownloading());
    }

    IEnumerator StillDownloading()
    {
        yield return new WaitUntil(() => transform.childCount > 0);

        DownloadIsFinished = true;
    }
}