using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public GameObject waterPlane;
    
    private float deltaTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(waterPlane);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log(fps);
        }
    }
}
