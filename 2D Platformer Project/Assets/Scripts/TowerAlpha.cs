using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAlpha : MonoBehaviour
{
    private Vector3 towerProjectileStart;
    public ProjectileFireTest testPFT;

    private void Awake()
    {
        //finds the position in which to spawn projectiles
        towerProjectileStart = transform.Find("TowerProjectileStart").position;
    }


    // Update is called once per frame
    private void Update()
    {
        //Once left click it shoots
        if( Input.GetMouseButtonDown(0) )
        {
            testPFT.Create(towerProjectileStart, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    
}
