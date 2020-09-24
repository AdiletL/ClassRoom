using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip[] _audioClips;
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;
    public TrajectoryRendererlvl10 tr;
    private float speed;
    
    public float speedBullet, angle ,power, plwsPlus, plwsMinus;
    
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stena"))
        {
            _audioSource.PlayOneShot(_audioClips[0], 0.5f);
            Vector3 dir = collision.contacts[0].normal;
            if (tr.plas < -12)
            {
                angle = tr.plas * tr.plas + plwsPlus - tr.plas * -30;
            Vector3 plus = new Vector3(transform.position.x - angle, transform.position.y, transform.position.z);
            _rigidbody.AddForce(dir * power - plus, ForceMode.Impulse);
                
            }
            else
            {
                angle = tr.plas * tr.plas + plwsMinus - tr.plas * -30;
                Vector3 plus = new Vector3(transform.position.x - angle, transform.position.y, transform.position.z);
                _rigidbody.AddForce(dir * power - plus, ForceMode.Impulse);

            }
        


        }
        if (collision.gameObject.CompareTag("UseGravity"))
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
            _rigidbody.useGravity = true;
        }
    }
}
