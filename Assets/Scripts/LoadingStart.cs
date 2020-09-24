using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingStart : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.GetInt("SaveScene") > 0)
        {
SceneManager.LoadScene(PlayerPrefs.GetInt("SaveScene"));
        }

    }
}
