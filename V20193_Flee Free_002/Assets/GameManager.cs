using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Playera playera; //Spieler A
    public Ballaa ballaa;   //Kreis
    public Stabaa stabaa;   //Quadrat
    public Stabab stabab;   //Stab vertikal
    public Stabac stabac;   //Stab horizontal

    //public float speed;    //Diese Variable gilt für alle Skripte, klappt nicht

    public static Vector2 bottomLeft;   //Pixel unten-links vom Bildschirm
    public static Vector2 topRight;     //Pixel oben-rechts vom Bildschirm

    // Start is called before the first frame update
    void Start()
    {
        //Konvertiert Pixel-Koordinaten vom Bildschirm  zu  Koordinaten vom Spiel - hier (0,0) und (rechts, oben)
        bottomLeft = Camera.main.ScreenToWorldPoint (new Vector2 (0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width, Screen.height));


        //Erzeugen vom Ball, Stabaa (Lang), Stabab (Hoch)
        Instantiate(playera);
        Instantiate(ballaa);
        Instantiate(stabaa);
        Instantiate(stabab);
        Instantiate(stabac);
        
    }
}
