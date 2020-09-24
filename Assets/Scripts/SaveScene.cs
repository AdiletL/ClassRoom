using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SaveScene", SceneManager.GetActiveScene().buildIndex +0);
        PlayerPrefs.Save();
    }

}
