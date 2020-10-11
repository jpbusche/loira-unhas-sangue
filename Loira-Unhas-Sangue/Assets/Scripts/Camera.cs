using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    [SerializeField] Vector2 smoothTime, maxLimit, minLimit;

    Vector2 velocity;
    Transform target;

    // Start is called before the first frame update
    void Start() {
        target = GameObject.Find("Player").GetComponent<Transform>();
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update() {
        if(target != null) {
            float posX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref velocity.x, smoothTime.x); 
            float posY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref velocity.y, smoothTime.y);
            transform.position = new Vector3(posX, posY, transform.position.z);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minLimit.x, maxLimit.x), Mathf.Clamp(transform.position.y, minLimit.y, maxLimit.y), transform.position.z);
        }
    }
}
   
