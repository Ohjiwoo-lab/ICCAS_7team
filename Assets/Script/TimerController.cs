using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text TimerText;
    public float LimitTime;
    public Image GameOver;
    public GameObject GameClear;

    GameManager GM;

    // Update is called once per frame

    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {       
        TimerText.text = Mathf.Round(LimitTime).ToString() + "s";
        Debug.Log(LimitTime);

        
        if (LimitTime <= 0)
        {
            // 게임 클리어 오버 처리
            if (GM.Score >= 50)
            {
                Gameclear();
            }
            else if (GM.Score < 50)
            {
                Gameover();
            }
        }
        else
        {
            LimitTime -= Time.deltaTime;        
        }
    }


    void Gameover()
    {
        Debug.Log("game over");
        GameOver.gameObject.SetActive(true);
        GameObject.Find("Timer").gameObject.SetActive(false);
        GameObject.Find("ScoreScrollBar").gameObject.SetActive(false);
    }
    void Gameclear()
    {
        Debug.Log("game clear");
        GameClear.gameObject.SetActive(true);
        GameObject.Find("Timer").gameObject.SetActive(false);
        GameObject.Find("ScoreScrollBar").gameObject.SetActive(false);
    }
}
