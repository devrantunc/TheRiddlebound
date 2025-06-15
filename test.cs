using UnityEngine;

public class GoalTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("BÝR ÞEYLE ÇARPIÞTI: " + other.name);
    }
}