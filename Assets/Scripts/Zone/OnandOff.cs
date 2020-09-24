using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnandOff : MonoBehaviour
{
    public Traektorialvl10 player;
    private BoxCollider _box;
    [HideInInspector] public SpriteRenderer spr;
    public Number numer;

    private int audi;
    private void Start()
    {

        _box = GetComponent<BoxCollider>();
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (numer.number == true)
        {
            _box.enabled = false;
            spr.enabled = false;
            Invoke("Active", 6);
        }
        if (player.zone == true)
        {

            spr.enabled = false;
            _box.enabled = false;
        }
    }
    void Active()
    {
        _box.enabled = true;
        spr.enabled = true;
    }

}
