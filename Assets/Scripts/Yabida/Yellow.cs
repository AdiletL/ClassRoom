using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    [HideInInspector] public static bool _number = false;
    [HideInInspector] public bool number = false;

    public Animator _anim;
    
   
    public GroupColor groupColor;
    private void Start()
    {
        _anim = GetComponent<Animator>();
      
    }

    private void Update()
    {
        if (groupColor.colorgroup == true)
        {
            _anim.SetTrigger("Popadanie");
            number = true;
            number = false;
            _number = true;
            groupColor.colorgroup = false;
        }
    } 
}
