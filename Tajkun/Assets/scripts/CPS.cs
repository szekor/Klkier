using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CPS : MonoBehaviour
{
 public double ZarobekNaTick = 0;
 public int Tick, tickzapisany = 0;
 public Text ZPTtekst; 

    void Update(){
    ZPTtekst.text = "ZPT: $" + ZarobekNaTick;
    Tick = GameObject.Find("Scriptmanager").GetComponent<TimeTickSystem>().tick;
    if (Tick > tickzapisany)
    {   
        GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz += ZarobekNaTick;
        tickzapisany = Tick;
        ZarobekNaTick = Math.Round(ZarobekNaTick, 5);
    }
  }
}
