using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle();
        pipesScript.speed = -12;
        StartCoroutine(spawnMeSomething());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstacle;

    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(0, 5);
        float randomY = Random.Range(0, 3);
        float targetX = transform.GetChild(obstacleIndex).transform.position.x;
        Vector3 spawnPosition = new Vector3(targetX ,randomY, 0f);
        
        //Transform spawnpoint = transform.GetChild(obstacleIndex).transform;
        
        //Instantiate(obstacle, spawnpoint.position, Quaternion.identity,transform);
        Instantiate(obstacle, spawnPosition, Quaternion.identity,transform);
        
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
