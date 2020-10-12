using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    
    [SerializeField] Text[] texts;
    [SerializeField] int maxStates;
    [SerializeField] AudioClip initialSound;
    int state = 0;
    enum StageSelect {Banheiro, Menu, Exit}

    
    void Start() {
        AudioSource.PlayClipAtPoint(initialSound, transform.position);
    }

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
            texts[2].text = "Jogar Novamente";
            texts[3].text = "Jogar Novamente";
            texts[4].text = "Menu";
            texts[5].text = "Menu";
        } else if (state == 1) {
            texts[0].text = "Jogar Novamente";
            texts[1].text = "Jogar Novamente";
            texts[2].text = "Menu";
            texts[3].text = "Menu";
            texts[4].text = "Sair";
            texts[5].text = "Sair";
        } else {
            texts[0].text = "Menu";
            texts[1].text = "Menu";
            texts[2].text = "Sair";
            texts[3].text = "Sair";
            texts[4].text = "";
            texts[5].text = "";
        }
    }
}
