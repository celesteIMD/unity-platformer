using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLeft;
    public Canvas timeOutScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        timeOutScreen.gameObject.SetActive(false);
        timeLeft = 40f;
        timerText.text = Mathf.RoundToInt(timeLeft).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = Mathf.RoundToInt(timeLeft).ToString();
        if (timeLeft <= 0.0f)
        {
            timeOutScreen.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
        }
    }

}
