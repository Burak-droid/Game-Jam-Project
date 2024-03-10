using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonerPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public float durmaSüresi = 1.5f;

    
    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("cave"))
        {
           
        Invoke("SceneLoaders",1f);
        
        }
    }

    void SceneLoaders(){ 
        SceneManager.LoadSceneAsync("FurkanScene");
    }


}

