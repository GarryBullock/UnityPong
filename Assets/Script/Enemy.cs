using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed = 12;

    Vector3 targetPos;
    GameObject ball;
	
	// Update is called once per frame
	void Update () {
        this.ball = GameObject.FindGameObjectWithTag("Ball");
        if (this.ball != null) {
            this.targetPos = Vector3.Lerp(gameObject.transform.position, this.ball.transform.position, Time.deltaTime * speed);
            this.targetPos.y = Mathf.Clamp(this.targetPos.y, -12, 12);
            gameObject.transform.position = new Vector3(23, this.targetPos.y, 0);
        }
	}
}
