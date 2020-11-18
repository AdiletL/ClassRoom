using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Traektorialvl10 : MonoBehaviour
{
    public int quantityclass, quantitypaper, Stars;
    public float SpeedRotate, sped, Power = 50;
    public AudioClip[] _audioClips;
    public int clickbayt;
    [HideInInspector] public float Popadanieclass, click, counter, interval = 1.5f, hitdist, intervalclick, timloosing, timloos;

    public Transform PosRay, BulletPos;
    public GameObject bullet;
    public TrajectoryRendererlvl10 Trajectory;
   

    public GameObject[] paper;


    private Animator _animator;
    private BoxCollider _box;
    private AudioSource _audiosourse;

    [HideInInspector] public Vector3 speed, mousPos;

    [HideInInspector] public bool zone = false, sdf = false, att = false;

    private void Start()
    {
        _box = GetComponent<BoxCollider>();
        _animator = GetComponent<Animator>();
        _audiosourse = GetComponent<AudioSource>();
       
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

            if (Popadanieclass != quantityclass )
            {
                if (click == quantitypaper && intervalclick == 0 || att == true)
                {
                    timloosing += Time.deltaTime;

                    if (timloosing >= 3)
                    {
                        if (Popadanieclass != quantityclass)
                        {
                            Trajectory.lineRendererComponent.enabled = false;
                            _animator.SetTrigger("Proigriw");
                            timloos += 1;
                        }
                    }
                    if (timloos == 1)
                    {
                        _audiosourse.PlayOneShot(_audioClips[1]);
                    }

                }

                if (click != quantitypaper && zone == false && att != true)
                {if (Input.GetMouseButtonDown(0))
                        {
                    if (counter >= interval && intervalclick == 0)
                    {
                            clickbayt += 1;
                            intervalclick = 1;
                            _box.enabled = true;
                           
                            _animator.SetTrigger("Zamah");
                            for (int i = 0; i < click; i++)
                            {
                                Destroy(paper[i]);
                            }
                            sdf = true;

                        }
                    }
                    if (intervalclick == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, SpeedRotate * Time.deltaTime);

                            Trajectory.lineRendererComponent.enabled = true;
                            speed = (targetPoint - transform.position) * Power;
                            Trajectory.ShowTrajectory(PosRay.position, speed);
                        }

                    }
                  
                    if (intervalclick == 1)
                    {
                        if (Input.GetMouseButtonUp(0))
                        {
                            counter = 0;
                            _box.enabled = false;
                            _animator.SetTrigger("Kidat");
                            click += 1;
                            intervalclick = 0;

                           
                        }
                    }
                    if (intervalclick == 0)
                    {
                        Trajectory.lineRendererComponent.enabled = false;
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * 2);
                    }
                }

                if (sdf == true)
                {
                   
                        if (Number._number == true || Yellow._number == true)
                        {
                            Popadanieclass += 1;
                            Number._number = false;
                        Yellow._number = false;
                            Debug.Log("Hit");
                            if (Popadanieclass == quantityclass)
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
        if (other.gameObject.CompareTag("Zone"))
        {
            zone = true;
            _animator.SetTrigger("Proigriw");
        }
        if (other.gameObject.CompareTag("Attack"))
        {
            att = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Attack"))
        {
            att = true;
        }
    }
    public void Kidanie()
    {
        if (click < quantitypaper + 1)
        {
            _audiosourse.PlayOneShot(_audioClips[0]);
            GameObject s = Instantiate(bullet, BulletPos.position, transform.rotation);
            s.GetComponent<Rigidbody>().AddForce(mousPos.normalized   * sped, ForceMode.Impulse);
        }
    }
}
