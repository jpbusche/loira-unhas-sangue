﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommandController : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene("Menu");
    }
}
