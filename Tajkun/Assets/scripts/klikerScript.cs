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

    public void Kliker() {
        kesz += zarobekPoKliku;
        Popup.text = zarobekPoKliku.ToString();
    } 

          public void Update(){


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



          public void Partikle(){
            Touch touch = Input.GetTouch (0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
            if(touch.phase == TouchPhase.Began)
            Instantiate (Particle, touchPos, Quaternion.identity);   
		  }
  }
    