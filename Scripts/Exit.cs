using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    public void leave(int MainMenu)
    {
        Application.Quit();
    }
}