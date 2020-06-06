using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  public int damage = 1;
  public float speed = 4.5f;

  private void Awake()
  {
    speed = 5.5f;
  }

  private void Update()
  {
    // moves left
    transform.Translate(Vector2.left * speed * Time.deltaTime);
  }

  // function called when obstacle colides
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      // player takes damage
      other.GetComponent<Player>().health -= damage;
      Debug.Log(other.GetComponent<Player>().health);
      Destroy(gameObject);
    }
  }

}
