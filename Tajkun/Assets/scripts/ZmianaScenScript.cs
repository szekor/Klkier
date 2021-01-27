using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZmianaScenScript : MonoBehaviour
{    public GameObject UpgradeCPS5, UpgradeCPS6, kliker, UpgradeKlikera, UpgradeCPS, UpgradeCps2, UpgradeCps3, UpgradeCps4, OKBUTTON;
     public int tak = 0;
     void Update()
     {
     //While Game Was Closed You Earned
     if (tak == 3)
     {
            OKBUTTON.SetActive (true);
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (false);
            UpgradeCps2.SetActive (false);
            UpgradeCps3.SetActive (false);
            UpgradeCps4.SetActive (false);
            UpgradeCPS5.SetActive (false);
            UpgradeCPS6.SetActive (false);
	 }
     //TRAKTOR
     if (tak == 2)
        {
            OKBUTTON.SetActive (false);
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (true);
            UpgradeCPS.SetActive (false);
            UpgradeCps2.SetActive (false);
            UpgradeCps3.SetActive (false);
            UpgradeCps4.SetActive (false);
            UpgradeCPS5.SetActive (false);
            UpgradeCPS6.SetActive (false);
	     }
     //CPS
        if (tak == 1)
        {
            OKBUTTON.SetActive (false);
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (true);
            UpgradeCps2.SetActive (true);
            UpgradeCps3.SetActive (true);
            UpgradeCps4.SetActive (true);
            UpgradeCPS5.SetActive (true);
            UpgradeCPS6.SetActive (true);
	     }
         //KLIKER
         if (tak == 0)
        {
            OKBUTTON.SetActive (false);
            kliker.SetActive (true);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (false);
            UpgradeCps2.SetActive (false);
            UpgradeCps3.SetActive (false);
            UpgradeCps4.SetActive (false);
            UpgradeCPS5.SetActive (false);
            UpgradeCPS6.SetActive (false);
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
