using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public Traektoria player;
    private BoxCollider _box;
    [HideInInspector] public SpriteRenderer spr;
    public Number _number;
    private float counter;
    private float ins = 6;
   
    private void Start()
    {
      
        _box = GetComponent<BoxCollider>();
        spr = GetComponent<SpriteRenderer>();
    }
 
    private void Update()
    {
        if (_number.thasd == 1)
        {
            counter += Time.deltaTime;
            _box.enabled = false;
            spr.enabled = false;
            if (counter >= ins)
            {
        
        _box.enabled = true;
        spr.enabled = true; _number.thasd = 0;
            }
        }
        if (player.zone == true)
        {

            spr.enabled = false;
            _box.enabled = false;
        }
    }
    void Active() {
       
    }

}
