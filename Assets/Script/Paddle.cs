using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public float speed = 1;
    public Vector3 position;
	
	// Update is called once per frame
	void Update () {
        float y = gameObject.transform.position.y + (Input.GetAxis("Vertical") * speed);
        this.position = new Vector3(-23, Mathf.Clamp(y, -12, 12), 0);
        gameObject.transform.position = this.position;
	}
}
