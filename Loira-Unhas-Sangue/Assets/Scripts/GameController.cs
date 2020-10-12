using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    [SerializeField] Vector2 Xpos, Ypos;
    [SerializeField] GameObject[] prefabs;
    [SerializeField] int numberOfNPC;
    [SerializeField] Text lifes;
    [SerializeField] AudioClip initialScreen;
    float x, y;
    Player player;
    void Start() {
        player = GameObject.FindObjectOfType<Player>();
        AudioSource.PlayClipAtPoint(initialScreen, transform.position);
        for(int i = 0; i < numberOfNPC; i++) {
            x = Random.Range(Xpos.x, Xpos.y);
            y = Random.Range(Ypos.x, Ypos.y);
            Instantiate(prefabs[Random.Range(0, 2)], new Vector3(x, y, 0), Quaternion.identity);
        }
    }

    void Update() {
        if (player.GetLifes() == 0) {
            player.ResetLifes();
            SceneManager.LoadScene("Perdeu");
        }
    }
}
