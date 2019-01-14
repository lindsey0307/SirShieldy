using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
    void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
	}
	
	// Update is called once per frame
	void Update () {
        //TO DO: write real game manager with game restart
        if (transform.position.x < -10f){
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }

    }

    void OnCollisionEnter2D(Collision2D col){

        float y = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
        Vector2 dir = new Vector2(1, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }

    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight){
        return (ballPos.y - racketPos.y) / racketHeight;
    }
}
