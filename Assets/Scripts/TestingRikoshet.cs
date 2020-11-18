using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingRikoshet : MonoBehaviour
{
    public AudioClip[] _audioClips;
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;
    public float power, plwsPlus;
    public Vector3 plus;
    public float dist;
    public Transform a;
    private int pr;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Classmate"))
        {
            _audioSource.PlayOneShot(_audioClips[1], 0.7f);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            Invoke("PosBul", 0.07f);
        }
        if (other.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.useGravity = true;
            _rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
    void PosBul()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
    }
    private void FixedUpdate()
    {
        if (_rigidbody.useGravity == true)
        {
            power = 0;
        }
        if (pr >= 3)
        {
            power = 0;
            _rigidbody.useGravity = true;
            _rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stena"))
        {
            pr += 1;
            dist = Vector3.Distance(a.position, transform.position);
            plus = new Vector3(transform.position.x, 0, 0);
            if (dist >= plwsPlus)
            {
                plus = plus * dist * 2.6f;
            }
            else
            {
                plus = plus * dist*2;
            }

            Vector3 dir = collision.contacts[0].normal;
            _rigidbody.AddForce(dir * power - plus, ForceMode.Impulse);
        }
        if (collision.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
            _rigidbody.useGravity = true;
        }
    }
}
