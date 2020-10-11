using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {
    Player player;
    GameObject student;

    void Start() {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update() {
       if (Input.GetKeyDown(KeyCode.Space)) {
           if (student != null && !player.GetSeen()) {
               Destroy(student);
           } else if (player.GetSeen()){
               player.DamagePlayer();
           }
       } 
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("NPC")) {
            student = col.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.CompareTag("NPC")) {
            student = null;
        }
    }
}
