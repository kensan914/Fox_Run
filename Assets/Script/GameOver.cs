using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject black, deadPlayer, player;
    Vector3 blk;
    GameObject phr;
    PlayerHitRock script;
    public static bool isGameOver=false;

    // Start is called before the first frame update
    void Start()
    {
        deadPlayer.SetActive(false);
        phr = GameObject.Find("player");
        script = phr.GetComponent<PlayerHitRock>();
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (script.HitMassage)
        {
            isGameOver = true;
            script.HitMassage = false;
            StartCoroutine("GameOverScene");
            StartCoroutine("Recession");
            StartCoroutine("Black");
            StartCoroutine("CameraMove");
            StartCoroutine("Dead");
            StartCoroutine("CameraShake");
        }
    }

    IEnumerator GameOverScene()
    {
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator Recession()
    {
        while (true)
        {
            deadPlayer.transform.position -= new Vector3(0.1f, 0, 0);
            black.transform.position -= new Vector3(0.1f, 0, 0);
            yield return null;
        }
    }

    IEnumerator Black()
    {
        black.SetActive(true);
        black.transform.position = new Vector3(-45, 0, 0);
        blk = black.transform.position;
        yield return new WaitForSeconds(0.6f);
        float val = 0.0000001f, val2 = 1.00001f;
        while (blk.x < -25.0f)
        {
            blk = black.transform.position;
            black.transform.position += new Vector3(val, 0, 0);
            val += 0.001f * (val2 = val2 * 1.3f);
            yield return null;
        }
    }

    IEnumerator CameraMove()
    {
        while (true)
        {
            Camera.main.transform.position -= new Vector3(0.1f, 0, 0);
            yield return null;
        }
    }

    IEnumerator Dead()
    {
        float gravity = 0.3f;
        deadPlayer.transform.position = player.gameObject.transform.position;
        deadPlayer.transform.localScale = player.gameObject.transform.localScale;
        deadPlayer.SetActive(true);
        while (gravity > -0.31f)
        {
            deadPlayer.transform.position += new Vector3(0, gravity, 0);
            gravity -= 0.02f;
            yield return null;
        }
    }

    IEnumerator CameraShake()
    {
        float ShakeVal = 0.3f;
        for (int i = 0; i < 4; i++)
        {
            Camera.main.transform.position += new Vector3(0, ShakeVal, 0);
            ShakeVal = -ShakeVal;
            yield return null;
        }
    }

    public static bool GetisGameOver()
    {
        return isGameOver;
    }
}
