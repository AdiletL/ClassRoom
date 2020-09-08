using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ParticleStars : MonoBehaviour
{
    private AudioSource _audioSource;
    public GameObject _ParticleStars;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void Particle() { _audioSource.Play(); Instantiate(_ParticleStars,transform.position, transform.rotation); }
}
