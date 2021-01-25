using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoZabiciu : MonoBehaviour
{
public int CzasAktualny = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
public int CzasZapisany;
    void Start()
    {

    }


    void Update()
    {
        CzasAktualny = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
    }
}
