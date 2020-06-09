﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public int score = 0;
  public Text scoreDisplay;
  public void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Obstacle"))
    {
      score++;
    }
  }

  public void Update()
  {
    scoreDisplay.text = score.ToString();
  }
}
