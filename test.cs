using UnityEngine;

public class GoalTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("B�R �EYLE �ARPI�TI: " + other.name);
    }
}