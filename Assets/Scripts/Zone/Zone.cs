using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public Traektoria player;
    private BoxCollider _box;
    [HideInInspector] public SpriteRenderer spr;
    public Number _num;

    private int audi;
    private void Start()
    {
      
        _box = GetComponent<BoxCollider>();
        spr = GetComponent<SpriteRenderer>();
    }
 
    private void Update()
    {
        if (_num._number == true)
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
    void Active() {
        _box.enabled = true;
        spr.enabled = true;
    }

}
