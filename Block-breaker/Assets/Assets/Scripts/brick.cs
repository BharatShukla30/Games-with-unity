using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {
    
	public Sprite[] hitSprites;
    public static int breakableCount=0;
    private int timesHit;
    //private AudioClip crack;
    private float vol = 1;
    private Levelmanager levelManager;
    public bool isBreakable;
    // Use this for initialization
    void Start()
    {
      //  crack = FindObjectOfType<AudioClip>();
        isBreakable = (this.tag == "Breakable");
        if(isBreakable==true)
        breakableCount++;
        timesHit = 0;
        levelManager = FindObjectOfType<Levelmanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {

       // AudioSource.PlayClipAtPoint(crack,this.transform.position,vol);//plays the audio clip at the place where the brick was
        isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            handleHits();


        }
        
    }
 	void handleHits()
    {
        this.timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (this.timesHit >= maxHits)
        {
            breakableCount--;
            levelManager.brickDestroyed();
            Destroy(gameObject);
            
        }

        else
        {
            LoadSprites();
        }
    }
	void LoadSprites()
    {
        int spriteIndex = this.timesHit - 1;
        if(hitSprites[spriteIndex])
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
           }
	
 	

}
