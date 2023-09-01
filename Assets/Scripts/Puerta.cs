using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta: MonoBehaviour
{

  void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.CompareTag("Player")){
        Destroy(gameObject);
    }
  }
  
}
