using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
     private TrailRenderer _trail;
     private Mesh _renderer;
     private EdgeCollider2D _collider2D;

    private void Start()
    {
        _trail = GetComponent<TrailRenderer>();
        _renderer = GetComponent<MeshFilter>().mesh;
        _collider2D = GetComponent<EdgeCollider2D>();
    }

    private void Update()
    {
        List<Vector2> points = new List<Vector2>();
        for (int position = 0; position < _trail.positionCount; position++)
        {
            points.Add(_trail.GetPosition(position));
        }
        _renderer.uv = points.ToArray();
        _collider2D.points = points.ToArray();
    }
}
