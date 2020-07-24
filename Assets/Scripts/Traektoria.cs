using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Traektoria : MonoBehaviour
{

    public float SpeedRotate;
    public float sped;
    public float Power = 50;
    private float hitdist = 0.0f;
    private float counter;
    public float interval;
    public float OF;
    

    public Transform PosRay;
    public GameObject[] Bullet;
    public Transform BulletPos;
    public TrajectoryRenderer Trajectory;
    public Number[] Popadanie;
    public AmountPaper amount;

    private Animator _animator;
     
   [HideInInspector] public Vector3 speed, mousPos;

   
    

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
  
        counter += Time.deltaTime;
      
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        
        if (playerPlane.Raycast(ray, out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

             mousPos = targetPoint - transform.position;

            if (Input.GetMouseButtonDown(0) && counter >= interval)
            {
                _animator.SetTrigger("Zamah");
            }

             if (Input.GetMouseButton(0))
            {
               transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, SpeedRotate * Time.deltaTime);
                
                Power = 50;
                speed = (targetPoint - transform.position) * Power;
                Trajectory.ShowTrajectory(PosRay.position, speed);
            }
            else
            {
                Power = 0;
                speed = (targetPoint - transform.position) * Power;
                Trajectory.ShowTrajectory(transform.position, speed);
            }
            if (Input.GetMouseButtonUp(0) && counter >=interval)
                {
                _animator.SetTrigger("Kidat");
                
                Mesto();
                counter = 0;
                }
          
        }
        var b = Popadanie[0];
        var q = Popadanie[1];
        var w = Popadanie[2];
        if (b._number == true || q._number == true || w._number == true)
        {
            OF += 0.2f;
            b._number = false;
            q._number = false;
            w._number = false;
            Debug.Log("Hit");
            if (OF == 0.6f)
            {
_animator.SetTrigger("Victory");
            }
            
        }
      
    }

    void Mesto() {        
        transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(0,90,0), 1); }

    public void Kidanie()
    {

        GameObject s = Instantiate(Bullet[1], BulletPos.position, transform.rotation);
                    s.GetComponent<Rigidbody>().velocity = mousPos * sped * Time.deltaTime; }
}


