using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
      
      public class klikerScript : MonoBehaviour
      {
          public GameObject Particle;
          public Text Popup;
          public Text hajstekst;
          public double kesz = 0;
          public double zarobekPoKliku = 1;
          
          public void Kliker(){    
              kesz += zarobekPoKliku;
              
          }
          public void Update(){              
              Popup.text = zarobekPoKliku.ToString();
              if (Input.touchCount > 0)
                {
                Touch touch = Input.GetTouch(0);
                Instantiate(Particle, touch.position, Quaternion.identity);
                Instantiate(Popup, touch.position, Quaternion.identity);} 

             if (kesz < 1000)
              hajstekst.text = "$" + Math.Round(kesz, 0).ToString();
              else if (kesz >= 1000 && kesz < 1000000)
              hajstekst.text = "$" + Math.Round(kesz / 1000, 2).ToString() + "K";
              else if (kesz >= 1000000 && kesz < 1000000000)
              hajstekst.text = "$" + Math.Round(kesz / 1000000, 2).ToString() + "M";
              else if (kesz >= 1000000000 && kesz < 1000000000000)
              hajstekst.text = "$" + Math.Round(kesz / 1000000000, 2).ToString() + "B";
              else if (kesz >= 1000000000000 && kesz < 1000000000000000)
              hajstekst.text = "$" + Math.Round(kesz / 1000000000000, 2).ToString() + "T";
              if (kesz > 1000)
              kesz = Math.Round(kesz, 2);
          }
  }
