using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // The Prefab we want to Instantiate
    [SerializeField] private GameObject coinPrefab;
    private int numberToSpawn;
    [SerializeField] private int coinPool;

    private Vector3 minPosition;
    private Vector3 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        numberToSpawn = 2;
        coinPool = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //When player presses spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Spawn a coin on object infinitely if space is down
            //Instantiate(coinPrefab, transform.position, Quaternion.identity, transform);

            //Spawn two coins at random locations
            Instantiate(coinPrefab, transform.position, Random.rotation, transform);
            coinPool++;
            Instantiate(coinPrefab, transform.position, Random.rotation, transform);
            coinPool++;

        }
    }
}
