using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speedBullet, power;
    private float speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
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
        if (collision.gameObject.CompareTag("Stena"))
        {
             Vector3 dir = collision.contacts[0].normal;
            Vector3 plus = new Vector3(transform.position.x - 85, transform.position.y, transform.position.z);
            _rigidbody.AddForce(dir * power - plus, ForceMode.Impulse);
        
        }
        if (collision.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
            _rigidbody.useGravity = true;
        }
       
        
    }
}
