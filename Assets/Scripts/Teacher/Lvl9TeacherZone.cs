using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl9TeacherZone : MonoBehaviour
{
    private Animator _animator;
    public Traektoria player;
    public WalkingStickmen walking;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (player.zone == true)
        {
            walking.speed = 0;
            _animator.SetTrigger("Teacher");
        }
    }
}
