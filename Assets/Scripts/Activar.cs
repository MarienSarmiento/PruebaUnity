using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
   public Canvas canvasAActivaar;

   void OnTriggerEnter(Collider other){
    if(other.CompareTag("Player")){
        canvasAActivaar.gameObject.SetActive(true);
    }
   }
}