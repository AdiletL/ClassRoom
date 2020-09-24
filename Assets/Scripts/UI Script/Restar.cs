using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restar : MonoBehaviour
{
   
    public int ler;
    private void FixedUpdate()
    {
        if (CameraAnim.level == 1)
        {
            ler = 1;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
        if (CameraAnim.level == 2)
        {
            ler = 2;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
    }
}
