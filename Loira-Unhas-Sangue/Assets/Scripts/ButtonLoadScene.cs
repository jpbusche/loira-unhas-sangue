﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour {

	public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void OnQuit() {
        Application.Quit();
    }
}

