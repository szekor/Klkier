using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TimeTickSystem : MonoBehaviour
{
  private const float TICK_TIMER_MAX =  0.2f;
  public Text liczbatickow;
  public int tick;
  private float tickTimer; 

  

  private void Awake()
  {
  tick = 0;
  }
  private void Update()
  {
	tickTimer += Time.deltaTime;
	if (tickTimer >= TICK_TIMER_MAX)
		{
		tickTimer -= TICK_TIMER_MAX;
		tick++;
		}
		liczbatickow.text = tick.ToString();
  }

}
