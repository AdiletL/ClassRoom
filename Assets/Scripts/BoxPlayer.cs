using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPlayer : Traektoria
{
    private BoxCollider _box;

    private void Start()
    {
        _box = GetComponent<BoxCollider>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _box.enabled = !_box.enabled;
        }
        if (Input.GetMouseButtonUp(0))
        {
            _box.enabled = !_box.enabled;
        }
    }
}
