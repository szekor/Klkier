using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using System;

public class banerAD : MonoBehaviour
{
    private string banerad = "bannerad";
    void Start()
    {
        Advertisement.Initialize(Settings.GameId, Settings.TestMode);
        StartCoroutine(ShowBanner());

    }
    IEnumerator ShowBanner()
    {
        while(!Advertisement.IsReady(banerad))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(banerad);
        Debug.Log("pokazano baner");
    }

}
