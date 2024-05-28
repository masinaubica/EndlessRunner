using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private int spawnInterval = 70;
    private int lastSpawnZ = 60;
    private int SpawnAmount = 2;
    private int initAmount = 5;

    public List<GameObject> obstacles;
    public List<GameObject> spawnedObstacles;

    private int maxActiveObstacle = 10;
    void Start()
    {
        spawnedObstacles = new List<GameObject>();

        for (int i = 0; i < initAmount; i++)
        {
            SpawnObstacles();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObstacles()
    {
        lastSpawnZ += spawnInterval;

        for (int i = 0; i < SpawnAmount; i++)
        {


            GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];

            Instantiate(obstacle, new Vector3(0, 0, lastSpawnZ), obstacle.transform.rotation);

            spawnedObstacles.Add(obstacle);


        }

        if (spawnedObstacles.Count > maxActiveObstacle)
        {
            int plotsToRemove = spawnedObstacles.Count - maxActiveObstacle;
            for (int i = 0; i < plotsToRemove; i++)
            {
                RemoveObstacle(spawnedObstacles[i]);
            }
        }


    }
    private void RemoveObstacle(GameObject obstacle)
    {

        if (obstacle != null && spawnedObstacles.Contains(obstacle))
        {

            spawnedObstacles.Remove(obstacle);
            Destroy(obstacle);

        }
    }


   
}