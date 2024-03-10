using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mutlosondanreferenca : MonoBehaviour
{
    // Start is called before the first frame update
      public float gecisSuresi = 7f; // Geçiş süresi (saniye)
    void Start()
    {
        // Belirtilen süre sonra SahneDegistir fonksiyonunu çağır
        Invoke("SahneDegistir", gecisSuresi);
    }

    void SahneDegistir()
    {
        SceneManager.LoadSceneAsync("FinishGame");
    }
}
