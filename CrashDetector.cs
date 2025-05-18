using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  float C_delay = 0.4f;
  [SerializeField] ParticleSystem crashEffect;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
         if(other.tag == "ground"){
           //SceneManager.LoadScene(0);
           Invoke("Crashdelay", C_delay);
           GetComponent<AudioSource>().Play(); 
           crashEffect.Play();

     }
   }
   void Crashdelay(){
    SceneManager.LoadScene(0); 
   }
}
