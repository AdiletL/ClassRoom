using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playlvl1 : MonoBehaviour
{
   
    public Traektoria _tr;
    public CameraAnim cameraAnim;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        cameraAnim.enabled = true;
        _tr.enabled = true;
        gameObject.SetActive(false);
        }
       
    }
}
