using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private GameControl gc;
    void Start()
    {
        gc = GameObject.Find("GameController").GetComponent<GameControl>();
        rb2d = GetComponent<Rigidbody2D>();
        
    }

   
    void Update()
    {
        if (gc.playerSpawnned == true)
            rb2d.velocity = new Vector2(gc.scrollspeed, 0);
        if (gc.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
            
    }
}
