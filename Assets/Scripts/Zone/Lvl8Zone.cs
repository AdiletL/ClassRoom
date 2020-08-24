using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8Zone : MonoBehaviour
{
    public Lvl8Teacher teacher;
    private SpriteRenderer spr;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (teacher.rotation == true)
        {
            spr.enabled = true;
        }
        if (teacher.rotation == false)
        {
            spr.enabled = false;
        }
    }
}
