using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Classmate"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            Invoke("PosBul", 0.1f);
        }
        if (other.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.useGravity = true;
        }
    }
    void PosBul()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);
        _rigidbody.useGravity = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.useGravity = true;
        }
    }
}
