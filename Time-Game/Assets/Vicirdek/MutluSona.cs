using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadSceneOnCharacterDeath : MonoBehaviour
{
   
        public string zemintag ="mutluson";

        private void OnTriggerEnter2D(Collider2D other){ 

            if(other.gameObject.CompareTag("mutluson")){

                Invoke("SahneYükleyici",0.5f);
        }

        }

        private void SahneYükleyici(){ 

                SceneManager.LoadSceneAsync("MutluSon");

        }


}
