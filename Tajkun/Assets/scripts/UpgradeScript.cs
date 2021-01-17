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
          double ulepszenie = 2;
          double ulepszenie2 = 3;
          double cena1 = 10;
          double cena2 = 50;
          double kesz;
          double ZarobekPoKliku = 1;
          public void Update()
          {
          kesz = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
		  GameObject.Find("Scriptmanager").GetComponent<klikerScript>().zarobekPoKliku = ZarobekPoKliku;
         }
          public void UpgradeKlikera(){

               if(kesz >= cena1){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena1;
                ZarobekPoKliku = ZarobekPoKliku * ulepszenie;
                cena1 = cena1 * ulepszenie2;
                hajstekst.text = "$" + kesz.ToString();
                UpgradeKlikertekst.text = "$" + cena1.ToString();
			   }
          
           }
           public void UpgradeCps1(){

               if(kesz >= cena2){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena2;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 0.2;
                cena2 = cena2 * ulepszenie2;
                hajstekst.text = "$" + kesz.ToString();
                UpgradeCpstext.text = "$" + cena2.ToString();
			   }
          
           }

		  
     
     
     
     
     }
