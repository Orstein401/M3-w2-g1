using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_pl : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float jumpVelocity;

    Rigidbody2D rb;
    Vector2 Velocity;
    bool jump;
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>(); 
    }
   
    void Update()
    {
        Velocity= rb.velocity;
        Velocity.x = Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump1"))
        {
            jump = true;
        }
       
       
    }
     void FixedUpdate()
    {
        if (jump)
        {
            Velocity.y = jumpVelocity;
            jump = false;
        }
        rb.velocity = Velocity;

    }
}
