using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    [SerializeField] GameObject blood;
    [SerializeField] AudioClip dieSound;
    [SerializeField] Image[] nails;
    Player player;
    GameObject student;

    void Start() {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update() {
       if (Input.GetKeyDown(KeyCode.Space)) {
           if (student != null && !player.GetSeen()) {
               Instantiate(blood, new Vector3(student.transform.position.x, student.transform.position.y, student.transform.position.z), Quaternion.identity);
               AudioSource.PlayClipAtPoint(dieSound, transform.position);
               Destroy(student);
           } else if (player.GetSeen()){
               player.DamagePlayer();
               Destroy(nails[player.GetLifes()]);
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
