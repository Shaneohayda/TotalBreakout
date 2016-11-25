using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Rival"))
        {
            SceneManager.LoadScene("YouFail_1");
        }
    }
}