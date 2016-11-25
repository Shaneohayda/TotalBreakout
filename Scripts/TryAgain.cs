using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{

    public void LoadScene(int level)
    {
        SceneManager.LoadScene("level");
    }
}
