using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
      
      public class UpgradeScript : MonoBehaviour
      {
          public Text hajstekst;
          public Text UpgradeKlikertekst;
          public Text UpgradeCpstext;
          double ulepszenie = 1.4;
          double ulepszenie2 = 1.5;
          public double cena1 = 10;
          public double cena2 = 25;
          public double kesz;
          public double ZarobekPoKliku = 1;
          public void Update()
          {
          kesz = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
          ZarobekPoKliku = Math.Round(ZarobekPoKliku, 2);  
		  GameObject.Find("Scriptmanager").GetComponent<klikerScript>().zarobekPoKliku = ZarobekPoKliku;
         }
          public void UpgradeKlikera(){

               if(kesz >= cena1){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena1;
                ZarobekPoKliku = ZarobekPoKliku * ulepszenie;
                cena1 = cena1 * ulepszenie2;
                if (cena1 < 1000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1, 2).ToString();
                if (cena1 >= 1000 && cena1 < 1000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000, 2).ToString() + "K";
                if (cena1 >= 1000000 && cena1 < 1000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000, 2).ToString() + "M";
                if (cena1 >= 1000000000 && cena1 < 1000000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000000, 2).ToString() + "B";
                if (cena1 >= 1000000000000 && cena1 < 1000000000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000000000, 2).ToString() + "T";
			    if (cena1 > 1000)
                cena1 = Math.Round(cena1, 2);
               }
          
           }
           public void UpgradeCps1(){

               if(kesz >= cena2){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena2;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 0.1;
                cena2 = cena2 * ulepszenie2;
                UpgradeCpstext.text = "$" +  Math.Round(cena2, 2).ToString();
                if (cena2 < 1000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2, 2).ToString();
                if (cena2 >= 1000 && cena2 < 1000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000, 2).ToString() + "K";
                if (cena2 >= 1000000 && cena2 < 1000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000, 2).ToString() + "M";
                if (cena2 >= 1000000000 && cena2 < 1000000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000000, 2).ToString() + "B";
                if (cena2 >= 1000000000000 && cena2 < 1000000000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000000000, 2).ToString() + "T";
                if (cena2 > 1000)
                cena2 = Math.Round(cena2, 2);
			   }
          
           }

		  
     
     
     
     
     }
