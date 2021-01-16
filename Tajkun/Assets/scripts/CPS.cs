using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPS : MonoBehaviour
{
 double ZarobekNaSekunde = 1;
 int Tick;
 int chuj = 1;

    void Update(){
    Tick = GameObject.Find("Scriptmanager").GetComponent<TimeTickSystem>().tick;
    if (Tick == 4)
    {
        if (chuj == 1)
        {
        GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz += ZarobekNaSekunde;
        chuj = 0;
        }
    }
    else if (Tick == 0)
    chuj = 1;
   }
}
