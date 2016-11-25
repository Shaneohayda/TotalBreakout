using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger1 : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            SceneManager.LoadScene("YouFail_2");
        }
    }
}
