using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject gaming;
    public Traektoria _tr;
    public CameraAnim cameraAnim;
    public void play()
    {
        gaming.SetActive(true);
        cameraAnim.enabled = true;
        _tr.enabled = true;
        gameObject.SetActive(false);
    }
}
