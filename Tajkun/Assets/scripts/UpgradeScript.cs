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
          public Text UpgradeCps2text;
          public Text UpgradeCps3text;
          public Text UpgradeCps4text;
          public Text UpgradeCps5text;
          public Text UpgradeCps6text;
          double ulepszenie = 1.2;
          public double cena1 = 50;
          public double cena2 = 10;
          public double cena3 = 100;
          public double cena4 = 1100;
          public double cena5 = 12000;
          public double cena6 = 130000;
          public double cena7 = 1400000;
          public double kesz;
          public double ZarobekPoKliku = 1;
          public double UlepszenieZarobekNaTick = 0.1;
          public void Update()
          {
          kesz = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
          ZarobekPoKliku = Math.Round(ZarobekPoKliku, 2);  
		  GameObject.Find("Scriptmanager").GetComponent<klikerScript>().zarobekPoKliku = ZarobekPoKliku;
          cena1 = Math.Round(cena1, 1);
          cena2 = Math.Round(cena2, 1);
          cena3 = Math.Round(cena3, 1);
          cena4 = Math.Round(cena4, 1);
          cena5 = Math.Round(cena5, 1);
          cena6 = Math.Round(cena6, 1);
          cena7 = Math.Round(cena7, 1);
               if (cena1 < 1000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1, 0).ToString();
                if (cena1 >= 1000 && cena1 < 1000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000, 1).ToString() + "K";
                if (cena1 >= 1000000 && cena1 < 1000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000, 1).ToString() + "M";
                if (cena1 >= 1000000000 && cena1 < 1000000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000000, 1).ToString() + "B";
                if (cena1 >= 1000000000000 && cena1 < 1000000000000000)
                UpgradeKlikertekst.text = "$" +  Math.Round(cena1 / 1000000000000, 1).ToString() + "T";
                if (cena2 < 1000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2, 0).ToString();
                if (cena2 >= 1000 && cena2 < 1000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000, 1).ToString() + "K";
                if (cena2 >= 1000000 && cena2 < 1000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000, 1).ToString() + "M";
                if (cena2 >= 1000000000 && cena2 < 1000000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000000, 1).ToString() + "B";
                if (cena2 >= 1000000000000 && cena2 < 1000000000000000)
                UpgradeCpstext.text = "$" +  Math.Round(cena2 / 1000000000000, 1).ToString() + "T";
                if (cena3 < 1000)
                UpgradeCps2text.text = "$" +  Math.Round(cena3, 0).ToString();
                if (cena3 >= 1000 && cena3 < 1000000)
                UpgradeCps2text.text = "$" +  Math.Round(cena3 / 1000, 1).ToString() + "K";
                if (cena3 >= 1000000 && cena3 < 1000000000)
                UpgradeCps2text.text = "$" +  Math.Round(cena3 / 1000000, 1).ToString() + "M";
                if (cena3 >= 1000000000 && cena3 < 1000000000000)
                UpgradeCps2text.text = "$" +  Math.Round(cena3 / 1000000000, 1).ToString() + "B";
                if (cena3 >= 1000000000000 && cena3 < 1000000000000000)
                UpgradeCps2text.text = "$" +  Math.Round(cena3 / 1000000000000, 1).ToString() + "T";
                if (cena4 < 1000)
                UpgradeCps3text.text = "$" +  Math.Round(cena4, 0).ToString();
                if (cena4 >= 1000 && cena4 < 1000000)
                UpgradeCps3text.text = "$" +  Math.Round(cena4 / 1000, 2).ToString() + "K";
                if (cena4 >= 1000000 && cena4 < 1000000000)
                UpgradeCps3text.text = "$" +  Math.Round(cena4 / 1000000, 2).ToString() + "M";
                if (cena4 >= 1000000000 && cena4 < 1000000000000)
                UpgradeCps3text.text = "$" +  Math.Round(cena4 / 1000000000, 2).ToString() + "B";
                if (cena4 >= 1000000000000 && cena4 < 1000000000000000)
                UpgradeCps3text.text = "$" +  Math.Round(cena4 / 1000000000000, 2).ToString() + "T";           
                if (cena5 < 1000)
                UpgradeCps4text.text = "$" +  Math.Round(cena5, 0).ToString();
                if (cena5 >= 1000 && cena5 < 1000000)
                UpgradeCps4text.text = "$" +  Math.Round(cena5 / 1000, 1).ToString() + "K";
                if (cena5 >= 1000000 && cena5 < 1000000000)
                UpgradeCps4text.text = "$" +  Math.Round(cena5 / 1000000, 1).ToString() + "M";
                if (cena5 >= 1000000000 && cena5 < 1000000000000)
                UpgradeCps4text.text = "$" +  Math.Round(cena5 / 1000000000, 1).ToString() + "B";
                if (cena5 >= 1000000000000 && cena5 < 1000000000000000)
                UpgradeCps4text.text = "$" +  Math.Round(cena5 / 1000000000000, 1).ToString() + "T";

                if (cena6 < 1000)
                UpgradeCps5text.text = "$" +  Math.Round(cena6, 0).ToString();
                if (cena6 >= 1000 && cena6 < 1000000)
                UpgradeCps5text.text = "$" +  Math.Round(cena6 / 1000, 1).ToString() + "K";
                if (cena6 >= 1000000 && cena6 < 1000000000)
                UpgradeCps5text.text = "$" +  Math.Round(cena6 / 1000000, 1).ToString() + "M";
                if (cena6 >= 1000000000 && cena6 < 1000000000000)
                UpgradeCps5text.text = "$" +  Math.Round(cena6 / 1000000000, 1).ToString() + "B";
                if (cena6 >= 1000000000000 && cena6 < 1000000000000000)
                UpgradeCps5text.text = "$" +  Math.Round(cena6 / 1000000000000, 1).ToString() + "T";

                if (cena7 < 1000)
                UpgradeCps6text.text = "$" +  Math.Round(cena7, 0).ToString();
                if (cena7 >= 1000 && cena7 < 1000000)
                UpgradeCps6text.text = "$" +  Math.Round(cena7 / 1000, 1).ToString() + "K";
                if (cena7 >= 1000000 && cena7 < 1000000000)
                UpgradeCps6text.text = "$" +  Math.Round(cena7 / 1000000, 1).ToString() + "M";
                if (cena7 >= 1000000000 && cena7 < 1000000000000)
                UpgradeCps6text.text = "$" +  Math.Round(cena7 / 1000000000, 1).ToString() + "B";
                if (cena7 >= 1000000000000 && cena7 < 1000000000000000)
                UpgradeCps6text.text = "$" +  Math.Round(cena7 / 1000000000000, 1).ToString() + "T";

         }
          public void UpgradeKlikera(){

               if(kesz >= cena1){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena1;
                ZarobekPoKliku = ZarobekPoKliku * 2;
                cena1 = cena1 * 8;
               }
          
           }
           public void UpgradeCps1(){

               if(kesz >= cena2){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena2;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 0.01;
                cena2 = cena2 * ulepszenie;
          


			   }}
           public void UpgradeCps2(){

               if(kesz >= cena3){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena3;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 0.1;
                cena3 = cena3 * ulepszenie;



			   }}
           public void UpgradeCps3(){

               if(kesz >= cena4){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena4;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 0.8;
                cena4 = cena4 * ulepszenie;
                
 

			   }}
               public void UpgradeCps4(){

               if(kesz >= cena5){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena5;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 7;
                cena5 = cena5 * ulepszenie; }}
                
                public void UpgradeCps5(){

                if(kesz >= cena6){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena6;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 75;
                cena6 = cena6 * ulepszenie;  }}
                
                public void UpgradeCps6(){

                if(kesz >= cena7){
                GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz -= cena7;
                GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick += 1000;
                cena7 = cena7 * ulepszenie;  }}

		  
     
     
     
     
     }
