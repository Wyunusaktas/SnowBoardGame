using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarryMoments : MonoBehaviour
{
    [SerializeField] float torgue;
    Rigidbody2D rgb;
    SurfaceEffector2D surfacefector;
    [SerializeField] float boostspeed;
    [SerializeField] float slowspeed;
    bool canMove = true;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
       
    }
   public void disableControl()
    {
        canMove = false;
    }

    
    void Update()
    {
        if (canMove == true)
        {
            Torgue();
            respontheboost();
        }

        
    }

     void Torgue()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rgb.AddTorque(torgue);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rgb.AddTorque(-torgue);
        }
    }
    void respontheboost()
    {
        if (Input.GetKey(KeyCode.W))
        {
            FindObjectOfType<SurfaceEffector2D>().speed = boostspeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            FindObjectOfType<SurfaceEffector2D>().speed = slowspeed;
        }

    }
}
