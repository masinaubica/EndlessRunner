using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    PlotSpawner plotSpawner;
    Obstacles obstaclesSpawner;

    void Awake()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
        obstaclesSpawner = GetComponent<Obstacles>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
        obstaclesSpawner.SpawnObstacles();


    }
}
