using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    //TODO: CHANGE THIS TO CHANGE FOR USER INPUT SO WE CAN USE THE SAME SCRIPT FOR ALL
    public GameObject towerPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(1) )
        {
            Instantiate(towerPrefab, new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0), Quaternion.identity);
        }
    }
}
