using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  public int score = 0;
  public void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Obstacle"))
    {
      score++;
      Debug.Log("SCORE >>" + score);
    }
  }
}
