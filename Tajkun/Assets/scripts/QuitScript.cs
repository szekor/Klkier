using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
