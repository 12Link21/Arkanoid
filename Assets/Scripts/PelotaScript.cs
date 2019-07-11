using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = (rb2d.velocity.x / 2) + (collision.collider.attachedRigidbody.velocity.x / 3);
            vel.y = rb2d.velocity.y;
            rb2d.velocity = vel;
        }
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(5,5), ForceMode2D.Impulse);
        }
        else
        {
            rb2d.AddForce(new Vector2(-5, 5), ForceMode2D.Impulse);
        }
    }
}
