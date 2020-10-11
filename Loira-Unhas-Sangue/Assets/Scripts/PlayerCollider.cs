using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    [SerializeField] GameObject blood;
    Player player;
    GameObject student;

    void Start() {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update() {
       if (Input.GetKeyDown(KeyCode.Space)) {
           if (student != null && !player.GetSeen()) {
               Instantiate(blood, new Vector3(student.transform.position.x, student.transform.position.y, student.transform.position.z), Quaternion.identity);
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
