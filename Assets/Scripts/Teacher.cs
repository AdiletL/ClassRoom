using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    public Zone _zone;
    private Animator _animator;
    private float counter;
    public float interval;
    void Start()
    {
        _animator = GetComponent<Animator>();
        interval = 5;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= interval)
        {
            interval = 10;
            _animator.SetTrigger("Teacher-180");
           
            counter = 0;
        }
        if (_zone.animator == true)
            {
                _animator.SetTrigger("TeacherEnd");
            }
    }
}
