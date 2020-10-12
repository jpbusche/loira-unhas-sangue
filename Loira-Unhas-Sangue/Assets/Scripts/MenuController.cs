using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    [SerializeField] Text[] texts;
    [SerializeField] int maxStates;
    int state = 0;
    enum StageSelect {Banheiro, Comandos, Exit}


    void Update() {
        ShowState();
        if (Input.GetKeyDown(KeyCode.A) && state > 0) {
            state--;
        }
        else if(Input.GetKeyDown(KeyCode.D) && state < maxStates) {
            state++;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            string selected = System.Enum.GetName(typeof(StageSelect), state);
            if (selected == "Exit") Application.Quit();
            SceneManager.LoadScene(selected);
        }
    }

    void ShowState() {
        if (state == 0) {
            texts[0].text = "";
            texts[1].text = "";
            texts[2].text = "Jogar";
            texts[3].text = "Jogar";
            texts[4].text = "Comandos";
            texts[5].text = "Comandos";
        } else if (state == 1) {
            texts[0].text = "Jogar";
            texts[1].text = "Jogar";
            texts[2].text = "Comandos";
            texts[3].text = "Comandos";
            texts[4].text = "Sair";
            texts[5].text = "Sair";
        } else {
            texts[0].text = "Comandos";
            texts[1].text = "Comandos";
            texts[2].text = "Sair";
            texts[3].text = "Sair";
            texts[4].text = "";
            texts[5].text = "";
        }
    }
}