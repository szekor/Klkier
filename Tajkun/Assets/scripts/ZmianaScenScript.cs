using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaScenScript : MonoBehaviour
{    public GameObject kliker, UpgradeKlikera, UpgradeCPS, UpgradeCps2, UpgradeCps3;
     public int tak = 0;
     void Update()
     {
     //TRAKTOR
     if (tak == 2)
        {
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (true);
            UpgradeCPS.SetActive (false);
            UpgradeCps2.SetActive (false);
            UpgradeCps3.SetActive (false);
	     }
     //CPS
        if (tak == 1)
        {
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (true);
            UpgradeCps2.SetActive (true);
            UpgradeCps3.SetActive (true);
	     }
         //KLIKER
         if (tak == 0)
        {
            kliker.SetActive (true);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (false);
            UpgradeCps2.SetActive (false);
            UpgradeCps3.SetActive (false);
	     }
    }

     public void ZmianascenyKliker()
    {
     tak = 0;
	}
    public void ZmianascenyCPS()
    {
     tak = 1;
	}
    public void ZmianascenyTRAKTOR()
    {
     tak = 2;
	}
}
