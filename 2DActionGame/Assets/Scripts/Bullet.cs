using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    //’e‘¬
    private float speed = 10f;
    //•ûŒü
    private Vector2 direction;
    // Start is called before the first frame update
    void Start() {
        direction = transform.right;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
