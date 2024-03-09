using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monkeyhealth : MonoBehaviour
{
    private bool temasOldu = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            temasOldu = true;
            Invoke("YenidenYukle", 1f); // 1 saniye sonra YenidenYukle fonksiyonunu çağır
        }
    }

    private void YenidenYukle()
    {
        int sahneIndeksi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahneIndeksi);
    }
}
