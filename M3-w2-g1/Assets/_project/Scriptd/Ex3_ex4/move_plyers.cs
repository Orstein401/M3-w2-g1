using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_plyers : MonoBehaviour
{
    [SerializeField] int numPlayer;
    [SerializeField] float speed;
    [SerializeField] float jumpVelocity;

    Rigidbody2D rb;
    Vector2 Velocity;
    bool jump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Velocity = rb.velocity;
       
            Velocity.x = Input.GetAxis($"Horizontal{numPlayer}")*speed;
            if (Input.GetButtonDown($"Jump{numPlayer}"))
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
