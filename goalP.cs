using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.WinGame();
        }
    }
}