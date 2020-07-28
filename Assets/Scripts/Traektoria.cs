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
    public float Popadanieclass;
    public float amount;
    

    public Transform PosRay;
    public GameObject Bullet;
    public Transform BulletPos;
    public TrajectoryRenderer Trajectory;
    public Number[] Popadanie;
    public GameObject[] paper;

    private Animator _animator;
     
   [HideInInspector] public Vector3 speed, mousPos;

   
    

    private void Start()
    {
        _animator = GetComponent<Animator>();
        interval = 0;
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
            if (Popadanieclass != 0.6f)
            {

                if (amount != 5)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        interval = 0.9f;
                        _animator.SetTrigger("Zamah");

                        if (amount == 0)
                        {
                            Destroy(paper[0]);
                        }
                        if (amount == 1)
                        {
                            Destroy(paper[1]);
                        }
                        if (amount == 2)
                        {
                            Destroy(paper[2]);
                        }
                        if (amount == 3)
                        {
                            Destroy(paper[3]);
                        }
                        if (amount == 4)
                        {
                            Destroy(paper[4]);
                        }
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
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * 2);
                    }
                    if (Input.GetMouseButtonUp(0))
                    {
                        _animator.SetTrigger("Kidat");

                    }
                }

                if (Input.GetMouseButtonDown(0) && counter >= interval)
                {
                    interval = 0.9f;
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
                if (Input.GetMouseButtonUp(0))
                {

                    _animator.SetTrigger("Kidat");

                    Mesto();

                }

            

            var b = Popadanie[0];
            var q = Popadanie[1];
            var w = Popadanie[2];
                if (b._numb == true || q._numb == true || w._numb == true)
                {
                    Popadanieclass += 0.2f;
                    b._numb = false;
                    q._numb = false;
                    w._numb = false;
                    Debug.Log("Hit");
                    if (Popadanieclass == 0.6f)
                    {
                        _animator.SetTrigger("Victory");
                    }
                }

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            amount += 1;
            if (amount == 1)
            {
            Destroy(paper[0]);
            }
            if (amount == 2)
            {
                Destroy(paper[1]);
            }
            if (amount == 3)
            {
                Destroy(paper[2]);
            }
            if (amount == 4)
            {
                Destroy(paper[3]);
            }
            if (amount == 5)
            {
                Destroy(paper[4]);
            }

        }
    }

    void Mesto() {        
        transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(0,90,0), 1); }

    public void Kidanie()
    {
        if (amount < 5)
        {
GameObject s = Instantiate(Bullet, BulletPos.position, transform.rotation);
                    s.GetComponent<Rigidbody>().velocity = mousPos * sped * Time.deltaTime;
           
        }
         }
}


