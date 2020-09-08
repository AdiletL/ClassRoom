using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRendererlvl10 : MonoBehaviour
{
    public Traektorialvl10 _traektoria;
    public LineRenderer lineRendererComponent;
    public int reflections = 4;
    public float maxLenght = 100;

    private Ray ray;
   [HideInInspector] public RaycastHit hit;
    private Vector3 direction;
    public float plas;
    public Vector3 sd;
    void Start()
    {
        
        lineRendererComponent = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (_traektoria.zone == true)
        {
            lineRendererComponent.enabled = false;
        }
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        ray = new Ray(transform.position, transform.right);

        lineRendererComponent.positionCount = 1;
        lineRendererComponent.SetPosition(0, transform.position);
        float remaininLenght = maxLenght;

        for (int i = 0; i < reflections; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remaininLenght))
            {
        
                lineRendererComponent.positionCount += 1;
                lineRendererComponent.SetPosition(lineRendererComponent.positionCount - 1, hit.point);
                remaininLenght -= Vector3.Distance(ray.origin, hit.point);
                
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                if (hit.collider.tag != "Stena")
                    
                {
                    break;
                   
                    
                }
                else
                {
                    plas = hit.point.x;
                    sd = hit.point;
                    lineRendererComponent.positionCount += 1;
                    lineRendererComponent.SetPosition(lineRendererComponent.positionCount - 1, ray.origin + ray.direction);

                }
             
            }
        }
    }
}
