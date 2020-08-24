using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float hitdist;
    float SpeedRotate = 50;
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.forward, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);

            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            if (Input.GetMouseButton(0))
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, SpeedRotate * Time.deltaTime);
                transform.position = targetPoint * 1 * Time.deltaTime;
            }
        }
    }
}
