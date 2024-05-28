using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 5;
    private float plotSize = 60f;
    private float xPosLeft = -40f;
    private float xPosRight = 40f;
    private float lastZPos = 75f;

    public List<GameObject> plots; 
    private List<GameObject> spawnedPlots; 

    private int maxActivePlots = 13;

    void Start()
    {
        spawnedPlots = new List<GameObject>();

        
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    void Update()
    {
        Debug.Log(spawnedPlots.Count);
    }

    public void SpawnPlot()
    {
        if (plots == null || plots.Count == 0)
        {
            Debug.LogError("No plots assigned or list is empty.");
            return;
        }

        GameObject plotLeft = Instantiate(plots[Random.Range(0, plots.Count)],
                                          new Vector3(xPosLeft, 0, lastZPos),
                                          Quaternion.identity);

        GameObject plotRight = Instantiate(plots[Random.Range(0, plots.Count)], new Vector3(xPosRight, 0, lastZPos), Quaternion.Euler(0, 180, 0));

        spawnedPlots.Add(plotLeft);
        spawnedPlots.Add(plotRight);

        lastZPos += plotSize;


        if(spawnedPlots.Count > maxActivePlots)
        {
            int plotsToRemove = spawnedPlots.Count - maxActivePlots;
            for(int i = 0; i < plotsToRemove; i++)
            {
                RemovePlot(spawnedPlots[i]);
            }
        }

        
    }

    private void RemovePlot(GameObject plot)
    {

        if (plot != null && spawnedPlots.Contains(plot))
        {

            spawnedPlots.Remove(plot);
            Destroy(plot);

        }
    }
}
