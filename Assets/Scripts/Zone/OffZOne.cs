using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffZOne : MonoBehaviour
{
    private float interval = 3;
    private float counter;
    private BoxCollider _box;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _box = GetComponent<BoxCollider>();
        _sprite = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("re") == 1)
        {
            counter += Time.deltaTime;
            if (counter>=interval)
            {
                _box.enabled = false;
                _sprite.enabled = false;
            }
            else
            {
                _box.enabled = true;
                _sprite.enabled = true;
            }
            if (counter >= 6)
            {
                counter = 0;
            }
        }
    }
}
