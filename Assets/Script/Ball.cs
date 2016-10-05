using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float velocity = 100;

    Rigidbody body;
    bool isPlay;
    int rand;

    void Awake () {
        body = gameObject.GetComponent<Rigidbody>();
        rand = Random.Range(1, 3);
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(0) == true && isPlay == false) {
            transform.parent = null;
            isPlay = true;
            body.isKinematic = false;
            
            switch (this.rand) {
                case 1:
                    body.AddForce(new Vector3(velocity, velocity, 0));
                    break;
                case 2:
                    body.AddForce(new Vector3(-velocity, -velocity, 0));
                    break;
            }
        }
	}
}
