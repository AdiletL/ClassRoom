using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
<<<<<<< HEAD

   [HideInInspector]  public bool _number = false;
=======
    public bool _number = false;
>>>>>>> parent of c04f0d6... Level3
    private Animator _anim;

    public bool _numb = false;

    private BoxCollider _Box;

    private void Start()
    {
        _Box = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            _numb = true;
            _Box.center = new Vector3(5, 5, 5);
        }
    }
}
