using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerUILobby : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI text;
    private float highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        displayhigh(highScore);
    }


    private void displayhigh(float timetoDisplay)
    {
        timetoDisplay += 1;
        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);
        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
