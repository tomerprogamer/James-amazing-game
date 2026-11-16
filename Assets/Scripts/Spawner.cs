using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle();
        StartCoroutine(spawnMeSomething());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstacle;

    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(0, 4);
        Transform spawnpoint =  transform.GetChild(obstacleIndex).transform;
        
        Instantiate(obstacle, spawnpoint.position, Quaternion.identity,transform);
        
    }

    IEnumerator spawnMeSomething()
    {
        while (true)
        {
        yield return new WaitForSeconds(1f);
        SpawnObstacle();
    }
}
}
