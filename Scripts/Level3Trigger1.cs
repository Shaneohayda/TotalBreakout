using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Level3Trigger1 : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Rival"))
        {
            SceneManager.LoadScene("YouFail_3");
        }
    }
}
