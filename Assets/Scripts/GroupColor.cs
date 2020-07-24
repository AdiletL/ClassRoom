using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupColor : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {

        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            _renderer.material.color = Color.red;
        }
    }
}
