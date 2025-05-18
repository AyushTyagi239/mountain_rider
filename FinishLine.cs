using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   [SerializeField] float delay = 1.5f;
   [SerializeField] ParticleSystem finishEffect;
   void OnTriggerEnter2D(Collider2D other){
     if(other.tag == "Player"){
        //SceneManager.LoadScene(0);
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
       Invoke("ReloadScreen", delay);
       
      
     }
   }
   void ReloadScreen(){
      SceneManager.LoadScene(0);
   }

}
