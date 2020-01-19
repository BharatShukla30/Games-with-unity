using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {
    static SoundControl instance=null;
     void Awake()
    {
        Debug.Log("Music player awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate music player destructing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    void Start () {
        Debug.Log("Music player start " + GetInstanceID());
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
