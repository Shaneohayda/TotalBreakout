using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{

    public void LoadScene(int MainMenu)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
