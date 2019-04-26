using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int poolsize = 5;
    public GameObject ColumnPrefab;
    private GameObject[] columns;
    private Vector2 ObjectPoolPosition = new Vector2(-15f, -25f);
    private float TimeSinceLastSpawned;
    public float Spawnrate=4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;
    private int currentColumn = 0;
    private float spawnXposition = 10f;

    private GameControl gc;

    void Start()
    {
        gc = GameObject.Find("GameController").GetComponent<GameControl>();
        columns = new GameObject[poolsize];
        for (int i = 0; i < poolsize; i++)
        {
            columns[i] = (GameObject)Instantiate(ColumnPrefab, ObjectPoolPosition, Quaternion.identity);
        }
    }


    void Update()
    {
        if (gc.playerSpawnned)
        {
            TimeSinceLastSpawned += Time.deltaTime;
            if (gc.gameOver == false && TimeSinceLastSpawned >= Spawnrate)
            {
                TimeSinceLastSpawned = 0;
                float spawnYPosition = Random.Range(columnMin, columnMax);
                columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnYPosition);
                currentColumn++;
                if (currentColumn >= poolsize)
                {
                    currentColumn = 0;
                }
            }
        }
    }
}
