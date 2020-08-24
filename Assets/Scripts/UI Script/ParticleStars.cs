using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStars : MonoBehaviour
{
    public GameObject _ParticleStars;
    public void Particle() { Instantiate(_ParticleStars,transform.position, transform.rotation); }
}
