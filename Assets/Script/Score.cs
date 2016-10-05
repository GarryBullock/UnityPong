using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public string player;
    public GameObject ballPrefab;
    public Transform paddleObj;

    ScoreManager scoreManager;
    GameObject ball;
	
	void Start () {
        this.scoreManager = (ScoreManager) GameObject.FindGameObjectWithTag("ScoreManager").GetComponent(typeof(ScoreManager));
        this.ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void OnTriggerEnter(Collider other) {
        this.ball = GameObject.FindGameObjectWithTag("Ball");
        if (other.tag == "Ball") {
            Destroy(this.ball);
            this.scoreManager.GoalScored(this.player);
            ((GameObject)Instantiate(this.ballPrefab, new Vector3(paddleObj.transform.position.x + 2, paddleObj.transform.position.y, 0), Quaternion.identity)).transform.parent = paddleObj;
        }
        else {
            Debug.Log("Tag of collider was not ball");
        }
    }
}
