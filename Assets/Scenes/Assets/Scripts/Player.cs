using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // load scenes

public class Player : MonoBehaviour
{
  private Vector2 targetPos;
  public float yIncrement = 5;
  public float speed = 50;
  public int maxHeight = 5;
  public int minHeight = 0;

  public int health = 5;
  private void Awake()
  {
    speed = 50.0f;
  }
  // Update is called once per frame
  void Update()
  {

    if (health <= 0)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
    {
      targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
    {
      targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
    }
  }
}
