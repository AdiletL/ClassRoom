using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlvl2 : MonoBehaviour
{
    public float SpeedRotate, sped, interval, Power = 50;
    private float hitdist, counter;

    [HideInInspector] public float amount, Popadanieclass;

    public Transform PosRay, BulletPos;
    public GameObject Bullet;
    public TrajectoryRenderer Trajectory;
    public Number[] Popadanie;
    public GameObject[] paper;

    private Animator _animator;

    [HideInInspector] public Vector3 speed, mousPos, targetPoint;
    [HideInInspector] public Quaternion targetRotation;

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
             targetPoint = ray.GetPoint(hitdist);

            targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            mousPos = targetPoint - transform.position;
            if (Popadanieclass != 0.8f )
            {
                if (amount != 6)
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
            if (amount == 5)
            {
                Destroy(paper[5]);
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
                        Invoke("Mesto", 0.3f);
                      
                    }
                    if (Input.GetMouseButtonUp(0))
                    {
                        _animator.SetTrigger("Kidat");

                    }
                    
                    var b = Popadanie[0];
                    var q = Popadanie[1];
                    var w = Popadanie[2];
                    var e = Popadanie[3];
                    if (b._number == true || q._number == true || w._number == true || e._number == true)
                    {
                        Popadanieclass += 0.2f;
                        b._number = false;
                        q._number = false;
                        w._number = false;
                        e._number = false;
                        Debug.Log("Hit");
                        if (Popadanieclass == 0.8f)
                        {
                            _animator.SetTrigger("Victory");
                        }
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
           

        }
    }

    void Mesto()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime*3);
    }

    public void Kidanie()
    {
        if (amount < 6)
        {
            GameObject s = Instantiate(Bullet, BulletPos.position, transform.rotation);
            s.GetComponent<Rigidbody>().AddForce(mousPos.normalized * sped, ForceMode.Impulse);
        }
    }
}
