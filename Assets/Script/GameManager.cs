using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Score;

    [SerializeField]
    private float DelayTime;

    public GameObject OBJ_ScrollContents;
    private Image IMG_ScrollContents;


    //완전 게임이 처음 실행될 때만 돌아감
    void Awake()
    {

    }

    // 씬에 처음 들어왔을 때
    void Start()
    {
        initFuntion();
        IMG_ScrollContents = OBJ_ScrollContents.GetComponent<Image>();
    }

    // 매 프레임마다 한번씩 돌아가는 
    void Update()
    {
        IMG_ScrollContents.fillAmount = (float)Score/100;
    }

    void initFuntion()
    {
        Score = 0;
    }

    public void ScoreUP()
    {
        StartCoroutine(DelayCorrectTime());
    }

    IEnumerator DelayCorrectTime()
    {
        Score += 10;
        yield return new WaitForSeconds(DelayTime);

    }
    
}
