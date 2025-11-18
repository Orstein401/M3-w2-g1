using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    int numberMember;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        
        if (collision.CompareTag("Player"))
        {
            numberMember += 1;
            Debug.Log(numberMember);
            if (numberMember == 2)
            {
                Debug.Log("hai raggiunto la fine");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            numberMember -= 1;
           
        }
    }
}
