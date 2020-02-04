using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballaa : MonoBehaviour
{


    //Diese Variable nur in diesem Script:
    //    [SerializeField]  
    //    float speed;

    //Diese Variable gilt für alle Scripte:
    public float speed;

    float radius;     //Radius vom Kreis?
    Vector2 direction;
    
    
    // Start is called before the first frame update
    void Start()
    {

        direction = Vector2.one.normalized;    // Anfangsrichtung ist (1,1) , Länge ist 1 ("normalized")
        radius = transform.localScale.x / 2;   //Halbe Weite vom Ball

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction * speed * Time.deltaTime);  //Bewegung vom Ball

        //Abprallen unten
        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;             
        }
        
        //Abprallen oben
        if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;             
        }

        //Abprallen links
        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0)
        {
            direction.x = -direction.x;
        }

        //Abprallen rechts
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0)
        {
            direction.x = -direction.x;
        }



    }
}
