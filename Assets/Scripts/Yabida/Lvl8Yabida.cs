using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8Yabida : Number
{
    public GameObject Particle;
    public Transform Object;
    public Traektoria player;
    public float speed, StartInterval;
    private float counter;
    
    void Update()
    {
        counter += Time.deltaTime;

        if (_number == true)
        {
            speed = 0;
        }
        if (speed == 0)
        {
transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0),1* Time.deltaTime);
        }
        if (player.zone == false)
        {
            if (counter <= StartInterval)
            {
                transform.Rotate(-Vector3.up * speed * Time.deltaTime);

            }
            if (counter >= 8)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
            }
            if (counter >= 16)
            {
                counter = 0;
            }
        }
        if (player.zone == true)
        {
            _anim.SetTrigger("Yabida");
        }

    }
    void Particl() { Instantiate(Particle, Object.position, transform.rotation); }
}
