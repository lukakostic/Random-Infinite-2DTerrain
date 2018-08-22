using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(LineRenderer))]
public class RandomTerrain2D : MonoBehaviour {
    public int numberOfPoints = 300;
    public float pointDistance = 2f;
    public float thickness = 2f;
    public float hillSize = 3f;
    public bool infinite = false;
    public bool deleteOnInfinite = true;

    [HideInInspector] public Vector2[] points;
    [HideInInspector] public Vector2[] allPoints;

    [HideInInspector] public PolygonCollider2D pc;
    [HideInInspector] public LineRenderer lr;

    [HideInInspector] public Transform nextTerrainToRight;

	void Start () {
        pc = GetComponent<PolygonCollider2D>();
        lr = GetComponent<LineRenderer>();

        lr.useWorldSpace = false;
        lr.startWidth = 0.2f;
        lr.endWidth = 0.2f;
        lr.loop = true;

        points = new Vector2[numberOfPoints];
        allPoints = new Vector2[numberOfPoints * 2];

        GeneratePoints();
        SmoothPoints();
        GenerateAllPoints();
        ApplyPoints();
	}

    void GeneratePoints()
    {
        points[0] = Vector2.zero;
        for (int i = 1; i < numberOfPoints; i++)
        {
            points[i] = points[i-1] + new Vector2(pointDistance,Random.Range(-hillSize,hillSize));
        }
    }

    void SmoothPoints()
    {
        for (int i = 1; i < numberOfPoints; i+=2)
        {
            points[i] = (points[i - 1] + points[i]) / 2f;
        }
        for (int i = 2; i < numberOfPoints; i += 2)
        {
            points[i] = (points[i - 1] + points[i]) / 2f;
        }
    }

    void GenerateAllPoints()
    {
        for (int i = 0; i < numberOfPoints; i++)
        {
            allPoints[i] = points[i];
            allPoints[numberOfPoints * 2 - 1 - i] = points[i] + Vector2.down*thickness;
        }
    }

    void ApplyPoints()
    {
        lr.positionCount = allPoints.Length;
        
        lr.SetPositions(ToV3(allPoints));
        pc.points = allPoints;
    }

    private void Update()
    {
        if(infinite == true)
        {
            infinite = false;

            GameObject clone = GameObject.Instantiate(gameObject);
            clone.transform.parent = transform;

            clone.transform.localPosition += new Vector3((numberOfPoints-1) * pointDistance - pointDistance/2f, points[numberOfPoints-1].y, 0f);

            clone.transform.parent = null;

            nextTerrainToRight = clone.transform;

            if (deleteOnInfinite) Destroy(gameObject);
        }
    }


    Vector3[] ToV3(Vector2[] v2)
    {
        Vector3[] v3 = new Vector3[v2.Length];

        for (int i = 0; i < v2.Length; i++)
        {
            v3[i] = new Vector3(v2[i].x, v2[i].y, 0f);
        }

        return v3;
    }
}
