     using System.IO;
     using System.Runtime.Serialization.Formatters.Binary;
     using UnityEngine;
     using UnityEngine.UI;
     using System;

     public class SaveLoad : MonoBehaviour 
     {   public int Roznica;
         public double CurrentHajs;
         public double CurrentCena1;
         public double CurrentCena2;
         public double CurrentCena3;
         public double CurrentCena4;
         public double CurrentCena5;
         public double CurrentZPC;
         public double CurrentZPT;
         public int CurrentCzasZapisany;
          public void Update()
          {
          CurrentHajs = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
          CurrentCena1 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena1;
          CurrentCena2 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena2;
          CurrentCena3 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena3;
          CurrentCena4 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena4;
          CurrentCena5 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena5;
          CurrentZPC = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().ZarobekPoKliku;
          CurrentZPT = GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick;
          CurrentCzasZapisany = GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasZapisany;
          }
          
         void Start()
         {
         LoadFile();
         GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasAktualny = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
         Roznica = GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasAktualny - GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasZapisany;
         GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz += (Roznica * (GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick * 10));
         }     

         public void SaveFile()
         {
             //Debug.Log(Application.persistentDataPath);
             string destination = Application.persistentDataPath + "/save.dat";
             FileStream file;
     
             if(File.Exists(destination)) file = File.OpenWrite(destination);
             else file = File.Create(destination);
     
             GameData data = new GameData(CurrentHajs, CurrentCena1, CurrentCena2, CurrentCena3, CurrentCena4, CurrentCena5, CurrentZPC, CurrentZPT, CurrentCzasZapisany);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(file, data);
             file.Close();
         }
     
         public void LoadFile()
         {
             string destination = Application.persistentDataPath + "/save.dat";
             FileStream file;
     
             if(File.Exists(destination)) file = File.OpenRead(destination);
             else
             {
                 Debug.LogError("File not found");
                 return;
             }
     
             BinaryFormatter bf = new BinaryFormatter();
             GameData data = (GameData) bf.Deserialize(file);
             file.Close();
             CurrentHajs = data.Hajs;
             CurrentCena1 = data.Cena1;
             CurrentCena2 = data.Cena2;
             CurrentCena3 = data.Cena3;
             CurrentCena4 = data.Cena4;
             CurrentCena5 = data.Cena5;
             CurrentZPC = data.ZPC;
             CurrentZPT = data.ZPT;
             CurrentCzasZapisany = data.CCZ;
             GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz = CurrentHajs;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena1 = CurrentCena1;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena2 = CurrentCena2;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena3 = CurrentCena3;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena4 = CurrentCena4;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena5 = CurrentCena5;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().ZarobekPoKliku = CurrentZPC;
             GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick = CurrentZPT;
             GameObject.Find("Scriptmanager").GetComponent<PoZabiciu>().CzasZapisany = CurrentCzasZapisany;
         }
     
     }
      [System.Serializable]
     public class GameData
 {   public double Hajs, Cena1, Cena2, Cena3, Cena4, Cena5, ZPC, ZPT; public int CCZ;
 
     public GameData(double Hajsdouble, double Cena1d, double Cena2d, double Cena3d, double Cena4d, double Cena5d, double ZPCd, double ZPTd, int CCZd)
     {   Hajs = Hajsdouble;
         Cena1 = Cena1d;
         Cena2 = Cena2d;
         Cena3 = Cena3d;
         Cena4 = Cena4d;
         Cena5 = Cena5d;
         ZPC = ZPCd;
         ZPT = ZPTd;
         CCZ = CCZd;
     }
 }
