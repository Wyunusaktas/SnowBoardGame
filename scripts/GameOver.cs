using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] ParticleSystem gameover;
    [SerializeField] AudioClip crash;
    BarryMoments bry;
   
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Floor")
        {
            
            gameover.Play();
            FindObjectOfType<BarryMoments>().disableControl();
            GetComponent<AudioSource>().PlayOneShot(crash);
            Invoke("invoke", 0.5f);
           
        }
    }
    void invoke()
    {

        SceneManager.LoadScene("level1");



    }
    
   
}
