using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : Number
{
    public float Rotate1, Rotate2, speed, StartInterval;
    public GameObject Particle;
    public Transform Object;
    public int EndStart;
    public Number num;
    private float counter;
    public Traektorialvl10 player;
    void Update()
    {
        counter += Time.deltaTime;

        if (num.thasd == 1)
        {
            speed = 0;

        }
        if (speed == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 1 * Time.deltaTime);
        }
        if (player.zone == false)
        {
            if (counter <= StartInterval)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Rotate1, 0), speed * Time.deltaTime);

            }
            if (counter >= StartInterval)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Rotate2, 0), speed * Time.deltaTime);
            }
            if (counter >= EndStart)
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
