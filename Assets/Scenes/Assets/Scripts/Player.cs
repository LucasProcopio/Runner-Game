using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // load scenes
using UnityEngine.UI;
public class Player : MonoBehaviour
{
  private Vector2 targetPos;
  public float yIncrement = 5;
  public float speed = 50;
  public int maxHeight = 5;
  public int minHeight = 0;
  public int health = 5;
  public Text healthDisplay;
  public GameObject effect;

  public GameObject gameOver;
  private void Awake()
  {
    speed = 50.0f;
  }
  // Update is called once per frame
  void Update()
  {

    healthDisplay.text = health.ToString();

    if (health <= 0)
    {
      gameOver.SetActive(true);
      Destroy(gameObject);
    }

    transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
    {
      Instantiate(effect, transform.position, Quaternion.identity);
      targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
    {
      Instantiate(effect, transform.position, Quaternion.identity);
      targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
    }
  }
}
