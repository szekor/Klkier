     using System.IO;
     using System.Runtime.Serialization.Formatters.Binary;
     using UnityEngine;
     using UnityEngine.UI;
  
     public class SaveLoad : MonoBehaviour 
     {
         public double CurrentHajs;
         public double CurrentCena1;
         public double CurrentCena2;
         public double CurrentCena3;
         public double CurrentCena4;
         public double CurrentZPC;
         public double CurrentZPT;

          public void Update()
          {
          CurrentHajs = GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz;
          CurrentCena1 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena1;
          CurrentCena2 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena2;
          CurrentCena3 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena3;
          CurrentCena4 = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena4;
          CurrentZPC = GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().ZarobekPoKliku;
          CurrentZPT = GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick;
          }
          
         void Start(){}     

         public void SaveFile()
         {
             //Debug.Log(Application.persistentDataPath);
             string destination = Application.persistentDataPath + "/save.dat";
             FileStream file;
     
             if(File.Exists(destination)) file = File.OpenWrite(destination);
             else file = File.Create(destination);
     
             GameData data = new GameData(CurrentHajs, CurrentCena1, CurrentCena2, CurrentCena3, CurrentCena4, CurrentZPC, CurrentZPT);
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
             CurrentZPC = data.ZPC;
             CurrentZPT = data.ZPT;
             GameObject.Find("Scriptmanager").GetComponent<klikerScript>().kesz = CurrentHajs;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena1 = CurrentCena1;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena2 = CurrentCena2;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena3 = CurrentCena3;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().cena4 = CurrentCena4;
             GameObject.Find("Scriptmanager").GetComponent<UpgradeScript>().ZarobekPoKliku = CurrentZPC;
             GameObject.Find("Scriptmanager").GetComponent<CPS>().ZarobekNaTick = CurrentZPT;
         }
     
     }
      [System.Serializable]
     public class GameData
 {   public double Hajs, Cena1, Cena2, Cena3, Cena4, ZPC, ZPT;
 
     public GameData(double Hajsdouble, double Cena1d, double Cena2d, double Cena3d, double Cena4d, double ZPCd, double ZPTd)
     {   Hajs = Hajsdouble;
         Cena1 = Cena1d;
         Cena2 = Cena2d;
         Cena3 = Cena3d;
         Cena4 = Cena4d;
         ZPC = ZPCd;
         ZPT = ZPTd;
     }
 }
