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


    //���� ������ ó�� ����� ���� ���ư�
    void Awake()
    {

    }

    // ���� ó�� ������ ��
    void Start()
    {
        initFuntion();
        IMG_ScrollContents = OBJ_ScrollContents.GetComponent<Image>();
    }

    // �� �����Ӹ��� �ѹ��� ���ư��� 
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
