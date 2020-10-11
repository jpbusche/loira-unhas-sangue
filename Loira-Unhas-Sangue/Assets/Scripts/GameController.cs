using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [SerializeField] Vector2 Xpos, Ypos;
    [SerializeField] GameObject[] prefabs;
    [SerializeField] int numberOfNPC;
    [SerializeField] Text lifes;
    float x, y;
    Player player;
    void Start() {
        player = GameObject.FindObjectOfType<Player>();
        for(int i = 0; i < numberOfNPC; i++) {
            x = Random.Range(Xpos.x, Xpos.y);
            y = Random.Range(Ypos.x, Ypos.y);
            Instantiate(prefabs[Random.Range(0, 2)], new Vector3(x, y, 0), Quaternion.identity);
        }
    }

    void Update() {
        lifes.text = "Vidas: " + player.GetLifes().ToString();
    }
}
