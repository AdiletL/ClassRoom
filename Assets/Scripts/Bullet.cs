using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;
    public float speedBullet, power;
    private float speed;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        speed = _rigidbody.velocity.magnitude;
        if (speed < speedBullet)
        {
            _rigidbody.useGravity = true;
            _rigidbody.constraints = RigidbodyConstraints.None;
        }
   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Classmate"))
        {
            _audioSource.Play();
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
            _rigidbody.useGravity = true;
        }
    }
}
