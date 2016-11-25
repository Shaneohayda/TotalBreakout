using UnityEngine;
using System.Collections;

public class PickUpClock : MonoBehaviour
{
    void OnTriggerEnter(Collider Clock)
    {
        if (Clock.gameObject.CompareTag("Clock"))
        {
            Clock.gameObject.GetComponent<myTimer>();
            Clock.gameObject.SetActive(false);

        }
    }
}
