using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueColor : MonoBehaviour
{
    public GroupColor groupColor;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    private void Update()
    {
        if (groupColor.colorgroup == true)
        {
            _renderer.material.color = Color.red;
        }
    }
}
