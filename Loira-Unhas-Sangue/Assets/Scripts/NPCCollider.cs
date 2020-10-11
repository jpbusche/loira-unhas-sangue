using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollider : MonoBehaviour {

    Player player;

    void Start() {
        player = GameObject.FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) player.SetSeen(true);
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.CompareTag("Player")) player.SetSeen(false);
    }

}
