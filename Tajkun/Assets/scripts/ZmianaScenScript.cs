using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaScenScript : MonoBehaviour
{    public GameObject kliker, UpgradeKlikera, UpgradeCPS;
     public int tak = 0;
     void Update()
     {
        if (tak == 1)
        {
            kliker.SetActive (false);
            UpgradeKlikera.SetActive (true);
            UpgradeCPS.SetActive (true);
	     }
         if (tak == 0)
        {
            kliker.SetActive (true);
            UpgradeKlikera.SetActive (false);
            UpgradeCPS.SetActive (false);
	     }
    }

     public void Zmianasceny()
    {
     if (tak == 0){tak = 1;}
     else if (tak == 1){tak = 0;}
	}
}
