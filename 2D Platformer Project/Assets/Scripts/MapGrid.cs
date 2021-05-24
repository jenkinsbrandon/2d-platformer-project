using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGrid 
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] mapGridArray;

    public MapGrid(int p_width, int p_height, float p_cellSize)
    {
        width = p_width;
        height = p_height;   
        cellSize = p_cellSize;

        mapGridArray = new int[width, height];

        for (int x = 0; x < mapGridArray.GetLength(0); x++)
        {
            for (int y = 0; y < mapGridArray.GetLength(1); y++)
            {
                
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }


}
