using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseTextController : MonoBehaviour
{
    public float restartDelay = 3f; // Bekleme süresi (saniye)

    void OnEnable()
    {
        // Bu UI aktif olduðunda geri sayým baþlasýn
        Invoke("RestartScene", restartDelay);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}