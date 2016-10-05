using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour {

    public int speed = 500;
    public Rigidbody body;

    void Awake () {
        body.velocity = new Vector3(speed, speed, 0);
    }
}
