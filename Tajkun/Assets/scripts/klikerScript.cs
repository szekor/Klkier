using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
      
      public class klikerScript : MonoBehaviour
      {
          public Text hajstekst;
          public double kesz = 0;
          public double zarobekPoKliku = 1;
          public void Kliker(){    
              kesz += zarobekPoKliku;             
          }
          public void Update(){           
              hajstekst.text = "$" + kesz.ToString();
          }
  }
