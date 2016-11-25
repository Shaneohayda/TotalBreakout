using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3Trigger : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            SceneManager.LoadScene("level3Loading");
        }
    }
}