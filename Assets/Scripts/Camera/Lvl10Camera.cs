using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl10Camera : MonoBehaviour
{
    public GameObject[] endStars, SKIP;
    public Traektorialvl10 player;
    public Next[] nextlvl;
    public Lvl10Camera cameraanim;

    bool timerminute = false;

    public Animator[] _animator;

    public Text minute, timerGaming, paperGaming;
    public Text[] paperEnd, timerEnd;


    public float timer, timerlvl5;
    private float timeStart, timeStars;
    private int countPaper, timermin;


    private void Start()
    {
        minute.text = 0 + ":".ToString();
        paperGaming.text = countPaper.ToString();
        timerGaming.text = timeStart.ToString();
        _animator[_animator.Length] = GetComponent<Animator>();
    }
    void Update()
    {
        if (player.Popadanieclass != player.quantityclass)
        {
            if (player.zone == false)
            {
                if (timerminute == false)
                {
                    if (countPaper < player.quantitypaper || player.intervalclick != 0)
                    {
                        timeStart += Time.deltaTime;
                        timerGaming.text = Mathf.Round(timeStart).ToString();
                        if (timeStart <= 9.5f)
                        {
                            timerGaming.text = "0" + Mathf.Round(timeStart).ToString();
                        }
                    }

                    if (player.click <= player.quantitypaper && player.counter >= player.interval)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            countPaper += 1;
                            paperGaming.text = countPaper.ToString();

                        }
                    }
                }
            }
        }
        else
        {
            timeStars += Time.deltaTime;
            _animator[0].SetTrigger("CameraVictory");
            if (player.Stars != player.click || timeStart >= timer)    // еще можно click==Popadanieclass
            {
                if (timeStars >= 3)
                {
                    endStars[0].SetActive(true);
                    paperEnd[0].text = countPaper.ToString();
                    timerEnd[0].text = Mathf.Round(timeStart).ToString();
                    if (timeStart <= 9.5f)
                    {
                        timerEnd[0].text = "0" + Mathf.Round(timeStart).ToString();
                    }
                    if (timeStars >= 3.5f)
                    {
                        _animator[1].SetTrigger("Stars");
                        if (timeStars >= 4.2f)
                        {
                            _animator[2].SetTrigger("Stars");
                        }
                    }
                }
                if (timeStars >= 6)
                {
                    SKIP[0].SetActive(true);
                }
            }
            else
            {
                if (timeStars >= 3)
                {
                    endStars[1].SetActive(true);
                    paperEnd[1].text = countPaper.ToString();
                    timerEnd[1].text = Mathf.Round(timeStart).ToString();
                    if (timeStart <= 9.5f)
                    {
                        timerEnd[1].text = "0" + Mathf.Round(timeStart).ToString();
                    }
                    if (timeStars >= 3.5)
                    {
                        _animator[3].SetTrigger("Stars");
                        if (timeStars >= 4)
                        {
                            _animator[5].SetTrigger("Stars");
                            if (timeStars >= 4.5f)
                            {
                                _animator[4].SetTrigger("Stars");
                            }
                        }
                    }
                }
                if (timeStars >= 6)
                {
                    SKIP[1].SetActive(true);
                }
            }
        }
        if (countPaper == player.quantitypaper)
        {
            if (Input.GetMouseButtonUp(0))
            {
                _animator[0].SetTrigger("CameraVictory");
            }
        }
        if (countPaper == player.quantitypaper && player.intervalclick == 0 || player.zone == true || timerminute == true)
        {
            timeStars += Time.deltaTime;
            if (timeStars >= 5)
            {
                if (player.Popadanieclass != player.quantityclass)
                {
                    endStars[0].SetActive(true);
                    paperEnd[0].text = countPaper.ToString();
                    timerEnd[0].text = Mathf.Round(timeStart).ToString();
                    if (timeStart <= 9.5f)
                    {
                        timerEnd[0].text = "0" + Mathf.Round(timeStart).ToString();
                    }
                    if (timeStars >= 5.5f)
                    {
                        _animator[1].SetTrigger("Stars");
                    }
                    if (timeStars >= 7)
                    {
                        SKIP[0].SetActive(true);
                    }
                }
            }
        }
        if (player.zone == true)
        {
            _animator[0].SetTrigger("Camera");
        }
        if (timeStart >= 59)
        {
            timeStart = 0;
            timeStart += Time.deltaTime;
            minute.text = 1 + ":".ToString();
            timermin = 1;
        }
        if (timermin == 1)
        {
            if (timeStart >= timerlvl5)
            {
                timeStart = timerlvl5;
                timerminute = true;
            }
        }
        if (nextlvl[0].LVL == true || nextlvl[1].LVL == true)
        {

            cameraanim.enabled = false;
            player.enabled = false;
        }
    }
}
