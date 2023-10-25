using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem prt;
     void OnCollisionExit2D(Collision2D collision)
    {
        prt.Stop();
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        prt.Play();
    }


}
