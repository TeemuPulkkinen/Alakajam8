using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float min_X = -5.85f, max_X = 5.7f;

    public GameObject minePrefab;
    //public GameObject enemyPrefab;

    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("SpawnEnemies", timer);

    }

    void SpawnEnemies()
    {

        float pos_X = Random.Range(min_X, max_X);
        Vector3 temp = transform.position;
        temp.x = pos_X;

        if(Random.Range(0, 2) > 0)
        {
            Instantiate(minePrefab, temp, Quaternion.Euler(0f, 0f, 90f));
        }
        //Poista kommentti!
        /*else
        {
            Instantiate(enemyPrefab, temp, Quaternion.Euler(0f, 0f, -90f));
        }*/

        Invoke("SpawnEnemies", timer);

    }
}
