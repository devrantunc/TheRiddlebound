using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseTextController : MonoBehaviour
{
    public float restartDelay = 3f; // Bekleme s�resi (saniye)

    void OnEnable()
    {
        // Bu UI aktif oldu�unda geri say�m ba�las�n
        Invoke("RestartScene", restartDelay);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}