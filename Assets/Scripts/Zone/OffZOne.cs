using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffZOne : MonoBehaviour
{

    public AudioClip[] _audioClips;
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;
    public TrajectoryRendererlvl10 tr;
    private float speed;
    public Vector3 df;
    public float angle, power, plwsPlus, plwsMinus;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stena"))
        {
            _audioSource.PlayOneShot(_audioClips[0], 0.5f);
            Vector3 dir = collision.contacts[0].normal;
            if (tr.plas < -12)
            {
                angle = tr.plas * tr.plas + plwsPlus - tr.plas + tr.plas;
                Vector3 plus = new Vector3(transform.position.x - angle, transform.position.y, transform.position.z);
                _rigidbody.AddForce(dir * power - plus, ForceMode.Impulse);

            }
            else
            {
                angle = tr.plas * tr.plas + plwsMinus - tr.plas * tr.plas;
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
