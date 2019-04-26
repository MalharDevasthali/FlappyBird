using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private GameControl gc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gc = GameObject.Find("GameController").GetComponent<GameControl>();
        if (collision.GetComponent<Bird>())
        {
            gc.BirdScored();
        }
    }
}
