using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    public bool _number = false;
    private BoxCollider _Box;

    private void Start()
    {
        _Box = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            _number = true;
            _Box.center = new Vector3(5, 5, 5);
        }
    }
}
