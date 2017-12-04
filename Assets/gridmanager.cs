using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridmanager : MonoBehaviour
{
    int x_cell=10;
    int z_cell;
    int max_tiles;


    static Vector3[] corners = { new Vector3(1, 0, 0), new Vector3(0,0,1)};
    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        for (int i = 0; i < x_cell; i++)
        {
            Debug.DrawLine(new Vector3(-5,0,i-5), new Vector3(5, 0, i-5), Color.red, 1000.0f);
        }
        for (int i = 0; i < x_cell; i++)
        {
            Debug.DrawLine(new Vector3(i-5, 0, -5), new Vector3(i-5, 0,5 ), Color.red, 1000.0f);
        }
        /*
        for (int i = 0; i < x_cell; i++)
        {
            drawRect(i, Color.black, Time.deltaTime);
        }
        */
    }
 
 
  
        
    
        
    /*
    Vector3 locateToCenter(Vector3 pos)
    {
        return pos + new Vector3(0.5f, 0, 0.5f);
    }
    */
    int vectorToCell(Vector3 pos)
    {
        return ((int)pos.z) * x_cell + (int)pos.x;
    }

    Vector3 cellToVector(int cellno)
    {
        return new Vector3(cellno % x_cell, cellno / x_cell);
    }

    void drawRect(int cellno, Color c, float duration = 1000.0f)
    {
        Vector3 left = cellToVector(cellno);
        Debug.DrawLine(left, left + corners[0], c, duration);
        Debug.DrawLine(left, left + corners[1], c, duration);
        Vector3 right = left + corners[0] + corners[1];
        Debug.DrawLine(right, right - corners[0], c, duration);
        Debug.DrawLine(right, right - corners[1], c, duration);
    }
    
  
   

}