using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
   public float objectLifeTime;
   
   public void Start()
   {
       // Destroys an  object after some amount of time
       Destroy(gameObject, objectLifeTime);
   }
}
