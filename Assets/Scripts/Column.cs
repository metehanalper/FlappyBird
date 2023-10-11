using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public GameObject ColumnsPrefabs;
    private int columnNumber = 5;
    private GameObject[] columns;

    private int minYposition = -2;
    private int maxYposition = 5;

    private float spawnTime = 0f;
    private float spawnRate = 4f;
    private int activeColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnNumber];
        for (int i = 0; i < columnNumber; i++)
        {
            columns[i] = (GameObject)Instantiate(ColumnsPrefabs, new Vector2(-40, -40), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        if ((spawnTime > spawnRate) && (GameControl.instance.gameOver == false))
        {
            Vector2 newPosition = new Vector2(10, Random.Range(minYposition, maxYposition));
            columns[activeColumn].transform.position = newPosition;
            spawnTime = 0;
            activeColumn++;
            if (activeColumn == columnNumber)
            {
                activeColumn = 0;
            }

        }


    }
}