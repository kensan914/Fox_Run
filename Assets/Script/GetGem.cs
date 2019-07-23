using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGem : MonoBehaviour
{
    static bool scoreBool;
    bool playerTotch = false,isntGot = true;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTotch)
        {
            Score.AddScore(5);
            StartCoroutine("GetGemAnim");
            playerTotch = false;
        }
    }

    IEnumerator GetGemAnim()
    {
        animator.SetBool("isGot", true);
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "player tag" && gameObject.GetComponent<Renderer>().sortingOrder == other.gameObject.GetComponent<Renderer>().sortingOrder && isntGot)
        {
            playerTotch = true;
            isntGot = false;
            scoreBool = true;
        }

    }

    public static bool getplayerTotch()
    {
        return scoreBool;
    }

    public static void setplayerTotch()
    {
        scoreBool = false;
    }

}
