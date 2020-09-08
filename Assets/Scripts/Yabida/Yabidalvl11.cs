using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yabidalvl11 : MonoBehaviour
{
    private Animator _animator;
    public Traektorialvl10 player;
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
