using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
      
      public class Guzikskrypt : MonoBehaviour
      {
          public Text hajstekst;
          public Text UpgradeKlikertekst;
          double kesz = 0;
          double ZarobekPoKliku = 1;
          double cena = 10;
          double ulepszenie = 2;
          double ulepszenie2 = 3;
          public void Kliker(){              
              kesz += ZarobekPoKliku;             
              hajstekst.text = "$" + kesz.ToString();
          }
          public void UpgradeKlikera(){
               if(kesz >= cena){
                kesz -= cena;
                ZarobekPoKliku = ZarobekPoKliku * ulepszenie;
                cena = cena * ulepszenie2;
                hajstekst.text = "$" + kesz.ToString();
                UpgradeKlikertekst.text = cena.ToString();
			   }
          
           
          }
     }