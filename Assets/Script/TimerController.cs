using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text TimerText;
    public float LimitTime;
    public Image GameOver;

    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        TimerText.text = Mathf.Round(LimitTime).ToString() + "s";
        Debug.Log(LimitTime);
        if (LimitTime <= 0)
        {
            Debug.Log("game over");
            GameOver.gameObject.SetActive(true);
        }
    }
}
