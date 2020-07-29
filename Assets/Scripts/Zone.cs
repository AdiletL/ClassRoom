using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
   [HideInInspector] public bool animator = false;
    private SpriteRenderer _spriteRenderer;
    private float counter;
    public float interval;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    { counter += Time.deltaTime;
        if (counter >= interval)
        {
            _spriteRenderer.enabled = !_spriteRenderer.enabled;
            counter = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Amount"))
        {
            animator = true;
        }
    }
}
