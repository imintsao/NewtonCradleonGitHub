using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int beamsCount = 2;


    // Start is called before the first frame update
    void Start()
    {
        CreateBeams(beamsCount);
        
        
    }


    private void CreateBeams(int totalBeams)
    {
        GameObject[] beamArray;
        beamArray = new GameObject[beamsCount];
        float zGap = 4.0f;
        float xScale = 4.0f;


        for (int i =0; i<totalBeams; i++)
        {
            beamArray[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            beamArray[i].transform.position = new Vector3(0f, 0f, zGap*i);
            beamArray[i].transform.localScale = new Vector3(xScale, 1f, 1f);


    
        }

        
    }

    
    void Update()
    {
        
    }
}
