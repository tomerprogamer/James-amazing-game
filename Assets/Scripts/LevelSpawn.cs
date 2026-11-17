using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public GameObject SpawnTo;
    public GameObject[] Levels;
    public float[] Lengths;
    public float Speed = 50;
    
    public int MaxCities = 5;
    private int nextLevel = 0;
    private float DistanceTravelled = 0;
    private List<GameObject> spawnedCities = new List<GameObject>();

    void Start()
    {
        SpawnNextLevel();
        pipesScript.speed = -50;
        for (int i = 0; i < 2; i++)
        {
            SpawnTo.transform.position += new Vector3(0, 0, -Lengths[nextLevel]);
            SpawnNextLevel();
        }
        DistanceTravelled = transform.position.z;
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, -pipesScript.speed * Time.deltaTime);

        if (transform.position.z - DistanceTravelled >= Lengths[nextLevel])
        {
            DistanceTravelled += Lengths[nextLevel];
            SpawnNextLevel();
        }
    }

    void SpawnNextLevel()
    {
        GameObject city = Instantiate(Levels[nextLevel], SpawnTo.transform.position, Quaternion.identity, transform);
        spawnedCities.Add(city);

        if (spawnedCities.Count > MaxCities)
        {
            Destroy(spawnedCities[0]);
            spawnedCities.RemoveAt(0);
        }

        nextLevel = Random.Range(0, Levels.Length);
    }
}