using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
      
      public class UpgradeScript : MonoBehaviour
      {
          public Text hajstekst;
          public Text UpgradeKlikertekst;
          double ulepszenie = 2;
          double ulepszenie2 = 3;
          double cena = 10;
          double kesz;
          double ZarobekPoKliku = 1;
          public void Update()
          {
          kesz = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
		  GameObject.Find("Scriptmanager").GetComponent<klikerScript>().zarobekPoKliku = ZarobekPoKliku;
         }
          public void UpgradeKlikera(){

               if(kesz >= cena){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena;
                ZarobekPoKliku = ZarobekPoKliku * ulepszenie;
                cena = cena * ulepszenie2;
                hajstekst.text = "$" + kesz.ToString();
                UpgradeKlikertekst.text = "$" + cena.ToString();
			   }
          
           }

		  
     
     
     
     
     }
