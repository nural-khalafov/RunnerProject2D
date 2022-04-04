using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadguySpawner : MonoBehaviour
{
    public GameObject Badguy;

    public float MinX;
    public float MaxX;

    public float MinY;
    public float MaxY;

    public float TimeBetweenSpawn;

    private float _spawnTime;

    private void Update()
    {
        if(Time.time > _spawnTime)
        {
            Spawn();
            _spawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    private void Spawn() 
    {
        float randomX = Random.Range(MinX, MaxX);
        float randomY = Random.Range(MinY, MaxY);

        Instantiate(Badguy, transform.position + new Vector3(randomX, randomY, 1f), transform.rotation);
    }
}
