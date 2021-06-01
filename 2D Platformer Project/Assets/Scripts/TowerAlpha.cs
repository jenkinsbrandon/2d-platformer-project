using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAlpha : MonoBehaviour
{
    private Vector3 towerProjectileStart;
    public ProjectileFireTest testPFT;

    private void Awake()
    {
        towerProjectileStart = transform.Find("TowerProjectileStart").position;
    }


    // Update is called once per frame
    private void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            testPFT.Create(towerProjectileStart, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    
}
