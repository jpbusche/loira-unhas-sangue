using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] Vector2 decisionTime;
    float timeCount, horizontal, vertical;
    Vector3 input, movement;
    Rigidbody2D body;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        input = Vector3.zero;
        timeCount = Random.Range(decisionTime.x, decisionTime.y);
    }

    void FixedUpdate() {
        Debug.Log(timeCount);
        if (timeCount > 0) timeCount -= Time.fixedDeltaTime;
        else {
            timeCount = Random.Range(decisionTime.x, decisionTime.y);
            input.x = Random.Range(-1, 2);
            input.y = Random.Range(-1, 2);
            Rotation();
        }
        movement = input.normalized * speed * Time.fixedDeltaTime;
        body.MovePosition(transform.position + movement);
    }

    void Rotation() {;
        if (input.x == 1 && input.y == 0) transform.localRotation = Quaternion.Euler(0, 0, 90);
        else if (input.x == -1 && input.y == 0) transform.localRotation = Quaternion.Euler(0, 0, 270);
        else if (input.x == 0 && input.y == 1) transform.localRotation = Quaternion.Euler(0, 0, 180);
        else if (input.x == 0 && input.y == -1) transform.localRotation = Quaternion.Euler(0, 0, 0);
        else if (input.x == 1 && input.y == -1) transform.localRotation = Quaternion.Euler(0, 0, 45);
        else if (input.x == 1 && input.y == 1) transform.localRotation = Quaternion.Euler(0, 0, 135);
        else if (input.x == -1 && input.y == 1) transform.localRotation = Quaternion.Euler(0, 0, 225);
        else if (input.x == -1 && input.y == -1) transform.localRotation = Quaternion.Euler(0, 0, 315);
    }
}
