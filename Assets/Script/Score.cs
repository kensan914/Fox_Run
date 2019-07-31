using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public　static int score;
    public Text scoreText;
    public AudioClip cherrySound;
    public AudioClip gemSound;
    AudioSource audioSouce;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        audioSouce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (GetCherry.getplayerTotch())
        {
            audioSouce.PlayOneShot(cherrySound);
            StartCoroutine("TextAnimC");
            GetCherry.setplayerTotch();
        }
        if (GetGem.getplayerTotch())
        {
            audioSouce.PlayOneShot(gemSound);
            StartCoroutine("TextAnimG");
            GetGem.setplayerTotch();
        }

    }

    public static int GetScore()
    {
        return score;
    }

    public static void AddScore(int val)
    {
        score += val;
    }

    IEnumerator TextAnimC()
    {
        scoreText.color = new Color(255f / 255f, 0, 0);
        yield return new WaitForSeconds(0.15f);
        scoreText.color = new Color(0, 0, 0);
    }

    IEnumerator TextAnimG()
    {
        scoreText.color = new Color(255f / 255f, 255f / 255f, 0);
        yield return new WaitForSeconds(0.15f);
        scoreText.color = new Color(0, 0, 0);
    }
}
