using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public static score instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoretxt;
    int scoreval = 0;
    int highscoreval = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscoreval = PlayerPrefs.GetInt("highscoreval", 0);  
        scoreText.text=scoreval.ToString();
        highscoretxt.text = "HIGHSCORE:" + highscoreval.ToString();
    }

    
    public void Addscore()
    {
        scoreval += 1;
        scoreText.text = scoreval.ToString();
        if (scoreval > highscoreval)
            PlayerPrefs.SetInt("highscoreval", scoreval);
    }
}
