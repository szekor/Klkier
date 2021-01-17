using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPS : MonoBehaviour
{
 public double ZarobekNaTick = 0;
 public int Tick, tickzapisany = 0;


    void Update(){
    Tick = GameObject.Find("Scriptmanager").GetComponent<TimeTickSystem>().tick;
    if (Tick > tickzapisany)
    {   
        GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz += ZarobekNaTick;
        tickzapisany = Tick;
    }
  }
}
