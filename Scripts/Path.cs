using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    private Dictionary<Vector3, Vector3> _pathPoints = new Dictionary<Vector3, Vector3>();
    private Vector3 _firstPoint;

    private void Awake()
    {
        Point[] points = GetComponentsInChildren<Point>();
        _firstPoint = points[0].transform.position;

        for (int i = 0; i < points.Length - 1; i++)
        {
            _pathPoints.Add(points[i].transform.position, points[i + 1].transform.position);
        }

        _pathPoints.Add(points[points.Length - 1].transform.position, _firstPoint);
    }

    public Vector3 GetFirstPoint()
    {
        return _firstPoint;
    }

    public Vector3 GetNextPoint(Vector3 point)
    {
        return _pathPoints[point];
    }
}