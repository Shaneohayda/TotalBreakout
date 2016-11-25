using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgain1 : MonoBehaviour
{

    public void LoadScene(int level2)
    {
        SceneManager.LoadScene("level2");
    }
}

