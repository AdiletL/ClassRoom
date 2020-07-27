using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{

    public GameObject BulletPrefab;
    public LineRenderer lineRendererComponent;

    // Start is called before the first frame update
    void Start()
    {
        lineRendererComponent = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        GameObject bullet = Instantiate(BulletPrefab, origin, Quaternion.identity);
        bullet.GetComponent<Rigidbody>

        Vector3[] point = new Vector3[3];
        //lineRendererComponent.positionCount = point.Length;

        for (int i = 0; i < point.Length; i++)
        {
            float time = i * 0.1f;

            point[i] = origin + speed * time + Physics.gravity * time * time / 2f;

            //if (point[i].y < 0)
            //{
            //    lineRendererComponent.positionCount = i;
            //    break;
            //}

        }
        lineRendererComponent.SetPositions(point);
    }



}
