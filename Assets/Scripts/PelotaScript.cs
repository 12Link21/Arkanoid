using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.down * 5.0f,ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
