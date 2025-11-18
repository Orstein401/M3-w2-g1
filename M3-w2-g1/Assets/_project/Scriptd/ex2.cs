using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ex2 : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.CompareTag("Finish"))
        {
            Debug.Log("hai raggiunto la fine");
        }
    }
}
