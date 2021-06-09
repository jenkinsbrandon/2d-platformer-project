using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OurVideoGame
{
public class TowerSpawner : MonoBehaviour
{
    //TODO: CHANGE THIS TO CHANGE FOR USER INPUT SO WE CAN USE THE SAME SCRIPT FOR ALL
    public GameObject towerPrefab;
    public TowerObject towerListObject;

    public int towerSelection = 0;




     List<TowerObject> towerList = new List<TowerObject>();

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(1) && IsTowerInProximity(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
        {
            towerListObject = new TowerObject(100,150,20,towerPrefab);

            towerListObject.SpawnTower(new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0));
            towerList.Add(towerListObject);
            Debug.Log(towerListObject.MaxHealth);
            
            
        }
    }


    //TODO: LATER CHANGE THIS TO DIFFERNT TOWER PROXIMITY DEPENDING ON TOWER TYPE
    private bool IsTowerInProximity(Vector3 mousePosition)
    {
        float distance = 0;
        foreach( TowerObject curObj in towerList)
        {
            //Find the distance between the chosen spawn position and every other tower
            //TODO Possibly change to k-d tree structure
            distance =  Mathf.Sqrt( Mathf.Pow( (mousePosition.x - curObj.spawnPosition.x), 2 ) + Mathf.Pow( (mousePosition.y - curObj.spawnPosition.y ),2) );
            if(distance < curObj.MinimumTowerProximity)
            {
                Debug.Log("TOWER TOO CLOSE " + curObj.MinimumTowerProximity);
                return false;
            }
        }
        return true;
    }
}
}
