using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    TextMesh playerScoreText;
    TextMesh enemyScoreText;

    int playerScore = 0;
    int enemyScore = 0;

	// Use this for initialization
	void Start () {
	    this.playerScoreText = GameObject.FindGameObjectWithTag("PlayerScore").GetComponentInChildren<TextMesh>();
        this.enemyScoreText = GameObject.FindGameObjectWithTag("EnemyScore").GetComponentInChildren<TextMesh>();
    }
	
    public void GoalScored(string tag) { 
        switch (tag) {
            case "Player":
                this.playerScore++;
                this.playerScoreText.text = this.playerScore.ToString();
                break;
            case "Enemy":
                this.enemyScore++;
                Debug.Log("Enemy Score: " + this.enemyScore);
                this.enemyScoreText.text = "" + this.enemyScore;
                break;
            default:
                Debug.Log("SCOREMANAGER: ID should be 1(player) or 2(enemy), was " + tag);
                break;
        }
        //reset the ball position??
    }
}
