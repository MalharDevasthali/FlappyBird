using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeating : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizonalLength;
    private GameControl gc;
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizonalLength = groundCollider.size.x;
        gc = GameObject.Find("GameController").GetComponent<GameControl>();
    }

  
    void Update()
    {
     if(transform.position.x < -groundHorizonalLength)
        {
            RepositionBG();
        }
    }

    private void RepositionBG()
    {
        Vector2 groundOffset=new Vector2(groundHorizonalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
