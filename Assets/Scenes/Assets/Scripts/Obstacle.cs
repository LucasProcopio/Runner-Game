using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  public int damage = 1;
  public float speed;

  public GameObject effect;
  public GameObject HitSound;
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
      Instantiate(effect, transform.position, Quaternion.identity);

      // player takes damage
      other.GetComponent<Player>().health -= damage;
      Instantiate(HitSound, transform.position, Quaternion.identity);
      Destroy(gameObject);
    }
  }

}
