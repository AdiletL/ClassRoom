﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    public Traektoria player;
    public LineRenderer lineRendererComponent;

    private void Start()
    {
        lineRendererComponent = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (player.zone == true)
        {
            lineRendererComponent.enabled = false;
        }
    }
    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
        lineRendererComponent.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;

            points[i] = origin + speed * time + Physics.gravity * time * time / 2f;

            if (points[i].y < 0)
            {
                lineRendererComponent.positionCount = i + 1;
                break;
            }
        }

        lineRendererComponent.SetPositions(points);
    }
}
