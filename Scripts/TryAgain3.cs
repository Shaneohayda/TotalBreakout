using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgain3 : MonoBehaviour
{

    public void LoadScene(int level3)
    {
        SceneManager.LoadScene("level3");
    }
}
