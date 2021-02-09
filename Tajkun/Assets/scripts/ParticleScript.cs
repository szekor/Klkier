using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    public Text popup;
    public void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {

                Instantiate(particle,touchPos, Quaternion.identity);
                Instantiate(popup, touchPos, Quaternion.identity); Debug.Log("pop");
            }
        }
    }
}

