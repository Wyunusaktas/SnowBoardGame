using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finish;
    [SerializeField] AudioClip fns;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="player")
        {
            finish.Play();
            GetComponent<AudioSource>().PlayOneShot(fns);
            Invoke("invoke", 0.5f);
        }
        
    }

    void invoke()
    {
        SceneManager.LoadScene(0);
    }



}


    