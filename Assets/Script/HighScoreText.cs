using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public Text highScoreText;
    int highScore,score;
    private string key = "HIGH SCORE";
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
        score = Score.GetScore();
        highScore = PlayerPrefs.GetInt(key, 0);
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(key, highScore);
            StartCoroutine("TextBlink");
        }
        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TextBlink()
    {
        text.enabled = true;
        yield return new WaitForSeconds(0.5f);
        for (int i=0;i<2;i++)
        {
            text.enabled = true;
            yield return new WaitForSeconds(1.0f);
            text.enabled = false;
            yield return new WaitForSeconds(0.2f);
        }
        text.enabled = true;
    }
}
