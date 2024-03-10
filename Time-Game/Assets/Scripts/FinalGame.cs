using UnityEngine;
using TMPro;

public class SFinalGame : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    public float gameDuration = 20f;
    public GameObject closeButton; 
    private bool gameClosed = false;

    void Update()
    {
        if (!gameClosed)
            transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
    }

    void Start()
    {
        Invoke("CloseGame", gameDuration);
    }

    void CloseGame()
    {
        gameClosed = true;
        closeButton.SetActive(true); 
    }

    
    public void QuitGame()
    {
      
        Application.Quit(); 
    }
}
