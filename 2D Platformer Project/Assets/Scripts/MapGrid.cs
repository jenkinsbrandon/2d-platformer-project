using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGrid 
{
    private int width;
    private int height;
    private float cellSize;
    private Vector3 startGridPosition;
    private bool[,] mapGridArray;

    private TextMesh[,] debugTextArray;

    public MapGrid(int p_width, int p_height, float p_cellSize, Vector3 p_startGridPosition)
    {
        width = p_width;
        height = p_height;   
        cellSize = p_cellSize;
        startGridPosition = p_startGridPosition;

        mapGridArray = new bool[width, height];
        debugTextArray = new TextMesh[width,height];

        for (int x = 0; x < mapGridArray.GetLength(0); x++)
        {
            for (int y = 0; y < mapGridArray.GetLength(1); y++)
            {
                debugTextArray[x,y] = CreateWorldText(null, mapGridArray[x, y].ToString(), GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * .5f, 
                        10, Color.white, TextAnchor.MiddleCenter, TextAlignment.Center);
                Debug.DrawLine( GetWorldPosition(x,y), GetWorldPosition(x, y+1), Color.white, 100f );
                Debug.DrawLine( GetWorldPosition(x, y), GetWorldPosition(x+1, y), Color.white, 100f );
            }
        }

        Debug.DrawLine( GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f );
        Debug.DrawLine( GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f );

        
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize + startGridPosition;
    }

    private void GetXY( Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt( (worldPosition-startGridPosition).x / cellSize);
        y = Mathf.FloorToInt( (worldPosition-startGridPosition).y / cellSize);
    }

    public void SetValue(int x, int y, bool value)
    {
        if(x >= 0 && y >= 0 && x < width && y < height)
        {
            mapGridArray[x,y] = value;
            debugTextArray[x,y].text = mapGridArray[x,y].ToString();
        }
    }

    public void SetValue( Vector3 worldPosition, bool value)
    {
        int x,y;
        GetXY(worldPosition, out x, out y);
        SetValue(x,y,value);
    }

    public bool GetValue( int x, int y)
    {
        if(x >= 0 && y >= 0 && x < width && y < height)
        {
            return mapGridArray[x,y];
        }
        else
        {
            return false;
        }
    }

    public bool GetValue(Vector3 worldPosition)
    {
        int x,y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }




    public TextMesh CreateWorldText(Transform parent, string text, Vector3 localPosition, int fontSize, Color color, TextAnchor textAnchor, TextAlignment textAlignment) {
        GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.anchor = textAnchor;
        textMesh.alignment = textAlignment;
        textMesh.text = text;
        textMesh.fontSize = fontSize;
        textMesh.color = color;
        return textMesh;
    }
}

