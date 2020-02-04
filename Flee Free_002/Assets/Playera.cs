using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    


    // Game over
    //if (???)
    //    {
    //        Debug.Log("Game over");
    //    }


    }


    void OnTriggerEnter2D(Collider2D other)          //Tags müssen gesetzt sein, Collider2D, Rigidbody2D muss eingefügt
    {
        if (other.tag == "Ballaa")
        {
            Debug.Log("Game over");         // Wird nur in der "Console" angezeigt!
            Time.timeScale = 0;             // Spiel wird angehalten
            enabled = false;                // Disable updationg Script
        }

    }



}
