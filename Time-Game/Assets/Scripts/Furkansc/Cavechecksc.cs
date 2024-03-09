using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavechecksc : MonoBehaviour
{
    public float durmaSüresi = 0.75f;

    
    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("cave"))
        {
           
            Invoke("OyunuDurdur", durmaSüresi);
        }
    }

    
    void OyunuDurdur()
    {
        Time.timeScale = 0f; 
    }

}
