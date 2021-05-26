using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMap : MonoBehaviour
{
    // Start is called before the first frame 
    public int row = 50;
    public int col = 25;
    public float size = 3f;
    Vector3 cameraDimensions;

    private MapGrid grid;
    private void Start()
    {
        cameraDimensions = Camera.main.ScreenToWorldPoint(new Vector3(0,0,10));
        grid = new MapGrid(row,col,size, cameraDimensions);
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0))
        {
            grid.SetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition), !grid.GetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        }

        if( Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        }
    }
}
