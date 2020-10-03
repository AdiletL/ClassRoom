using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnandOff : MonoBehaviour
{
    public Traektorialvl10 player;
    private BoxCollider _box;
    [HideInInspector] public SpriteRenderer spr;
    public Number numer;
    private float counter;
    private float ins = 6;
  
    private void Start()
    {

        _box = GetComponent<BoxCollider>();
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (numer.thasd == 1)
        {
            counter += Time.deltaTime;
            _box.enabled = false;
            spr.enabled = false;
            if (counter >= ins)
            {
                _box.enabled = true;
                spr.enabled = true;
                numer.thasd = 0;
            }
        }
        if (player.zone == true)
        {

            spr.enabled = false;
            _box.enabled = false;
        }
    }

}
