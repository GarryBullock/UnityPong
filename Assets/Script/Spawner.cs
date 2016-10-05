using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject ballPrefab;
    float x;
    float y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0)) {
            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            
            if (mousePos.x > 27.0f && mousePos.y < 580.0f && mousePos.y > 30.0f && mousePos.y < 319.0f) {
                Debug.Log(mousePos);
                Spawn(mousePos);
            }
            
        }
	}

    void Spawn (Vector2 location) {
        Debug.Log("Spawning a menu ball.");
        CreatePosition();
        Instantiate(this.ballPrefab, new Vector3(this.x, this.y, 0), Quaternion.identity);
    }

    void CreatePosition () {
        this.x = Random.Range(-8, 8);
        this.y = Random.Range(-4, 4);
    }
}
