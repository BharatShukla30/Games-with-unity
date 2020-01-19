using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 padtoball;
    private int a = 0;
    private Rigidbody2D rigi;
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        
        padtoball = this.transform.position - paddle.transform.position;
        audio = FindObjectOfType<AudioSource>();
        rigi = GetComponent<Rigidbody2D>();
	}
     void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, .2f), Random.Range(0f, .2f));
        audio.Play();
        rigi.velocity += tweak;

    }
    // Update is called once per frame
    void Update () {
        if (a == 0)
        {
            this.transform.position = paddle.transform.position + padtoball;
            if (Input.GetMouseButtonDown(0))
            {
                rigi.velocity = new Vector2(2f, 10f);
                
                a = 1;
            }
        }
		
	}
}
