using UnityEngine;
using System.Collections.Generic;

public class Waypoint : MonoBehaviour
{
    public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            if (transform.GetChild(i).GetChild(0).tag == "Waypoint")
                points[i] = transform.GetChild(i).GetChild(0);
        }
    }
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(points[i].name);
        }



    }

}
