using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 30f;
    public TextMeshProUGUI timerText;
    public GameObject winText;
    public GameObject loseText;

    private bool gameEnded = false;
    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        timerText.text = "Süre: " + Mathf.CeilToInt(timeLeft);

        if (timeLeft <= 0)
        {
            LoseGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("dgncn")) 
        {
            WinGame();

        }
    }
    public void WinGame()
    {

        gameEnded = true;
        winText.SetActive(true);
    }
    public void LoseGame()
    {
        gameEnded = true;
        loseText.SetActive(true);
    }
}