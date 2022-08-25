using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory singleton;
    public int totalPoints = 0;
    public Text points;

    public void Awake()
    {
        if(singleton==null)
        {
            singleton = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    public void AddInventory(int c)
    {
        totalPoints += c;
        points.text = totalPoints.ToString("00");
    }
}
