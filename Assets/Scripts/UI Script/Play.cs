using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject gaming;
    public Traektoria _tr;
    public CameraAnim cameraAnim;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void play()
    {
        Time.timeScale = 1;
        gaming.SetActive(true);
        cameraAnim.enabled = true;
        _tr.enabled = true;
        gameObject.SetActive(false);
    }
}
