using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose_collider : MonoBehaviour
{
    private Levelmanager levelmanager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        levelmanager = GameObject.FindObjectOfType<Levelmanager>();

        levelmanager.Loada("End");   
    }


}

