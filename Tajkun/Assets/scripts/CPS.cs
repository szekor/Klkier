using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CPS : MonoBehaviour
{
 public double ZarobekNaTick = 0;
 public int Tick, tickzapisany = 0, tickzapisany2 = 0, tickzapisany3 = 0;
 public Text ZPTtekst; 

    void Update(){
    ZPTtekst.text = ZarobekNaTick*10 + "/s";
    Tick = GameObject.Find("Scriptmanager").GetComponent<TimeTickSystem>().tick;
    if (Tick > tickzapisany)
    {   
        GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz += ZarobekNaTick;
        tickzapisany = Tick;
        ZarobekNaTick = Math.Round(ZarobekNaTick, 5);
    }
    else if (Tick >= (tickzapisany2 + 10))
    {   
        GameObject.Find("Scriptmanager").GetComponent<SaveLoad>().SaveFile();
        tickzapisany2 = Tick;
    }
    else if (Tick >= (tickzapisany3 + 10))
    {          
        tickzapisany3 = Tick;
        GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasZapisany = GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasAktualny;
    }
  }
}
