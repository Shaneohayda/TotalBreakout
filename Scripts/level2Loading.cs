﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level2Loading : MonoBehaviour
{
    public float Timer = 10;
    private Text timerText;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        timerText.text = Timer.ToString("f0");
        print(Timer);

        if (Timer <= 0)
        {
            SceneManager.LoadScene("level2");
        }
    }
}

