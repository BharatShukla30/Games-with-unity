using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public bool autoPlay = false;
    private Ball ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        if(autoPlay==false)
        moveWithMouse();
        else
        {
            Autoplay();
        }
    }
    void moveWithMouse()
    {
        Vector3 padpos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        float pos = Input.mousePosition.x / Screen.width * 16;
        padpos.x = Mathf.Clamp(pos, 1f, 15f);
        this.transform.position = padpos;

    }
    void Autoplay()
    {
        Vector3 padpos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        Vector3 ballpos = ball.transform.position;
        padpos.x = Mathf.Clamp(ballpos.x, 1f, 15f);
        this.transform.position = padpos;
    }
}
