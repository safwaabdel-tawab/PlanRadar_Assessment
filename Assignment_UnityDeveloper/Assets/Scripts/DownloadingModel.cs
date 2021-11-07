using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checking downloading process.
/// </summary>
public class DownloadingModel : MonoBehaviour
{
    public bool DownloadFinished
    {
        set; get;
    }
    void Start()
    {
        DownloadFinished = false;
        StartCoroutine(StillDownloading());
    }

    IEnumerator StillDownloading()
    {
        int count = transform.childCount;
        yield return new WaitUntil(() => count > 0);

        DownloadFinished = true;
    }
}
