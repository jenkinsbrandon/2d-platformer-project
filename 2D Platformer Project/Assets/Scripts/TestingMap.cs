using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMap : MonoBehaviour
{
    // Start is called before the first frame 
    public int row = 20;
    public int col = 10;
    public float size = 10f;

    private MapGrid grid;
    private void Start()
    {

       grid = new MapGrid(row,col,size, new Vector3(-20,-20));
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButton(0))
        {
            grid.SetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition), grid.GetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition)) + 1);
        }

        if( Input.GetMouseButton(1))
        {
            Debug.Log(grid.GetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        }
    }
}
