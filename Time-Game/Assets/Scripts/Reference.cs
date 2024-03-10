using UnityEngine;
using UnityEngine.UI;

public class Reference : MonoBehaviour
{
    public GameObject endGameButton;
    public float timeUntilButtonAppears = 10f;
    private float currentTime = 0f;
    private bool buttonVisible = false;

    void Update()
    {
        if (!buttonVisible)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= timeUntilButtonAppears)
            {
                endGameButton.SetActive(true);
                buttonVisible = true;
            }
        }
    }

    public void EndGame()
    {
        // Oyunu bitirme kodu buraya gelecek
        Debug.Log("Oyun bitti!");
        Application.Quit(); // Oyunu sonlandır (bu kısımda uygulamanın nasıl sonlandırılacağına bağlı olarak değişebilir)
    }
}
