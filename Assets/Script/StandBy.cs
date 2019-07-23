using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StandBy : MonoBehaviour
{
    public GameObject obj3, obj2, obj1;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = new Vector3(-6.5f, -1.35f, 1);
        obj3.SetActive(false);
        obj2.SetActive(false);
        obj1.SetActive(false);
        StartCoroutine("Count");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Count()
    {
        StartCoroutine("StandBy3");
        yield return new WaitForSeconds(1);
        StartCoroutine("StandBy2");
        yield return new WaitForSeconds(1);
        animator.SetBool("isStandBy", true);
        StartCoroutine("StandBy1");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Main");
    }

    IEnumerator StandBy3()
    {
        obj3.SetActive(true);
        for (int i = 0; i < 30; i++)
        {
            obj3.transform.localScale += new Vector3(0.1f,0.1f,0);
            yield return null;
        }
        for (int i = 0; i < 30; i++)
        {
            obj3.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
            yield return null;
        }
        obj3.SetActive(false);
    }

    IEnumerator StandBy2()
    {
        obj2.SetActive(true);
        for (int i = 0; i < 30; i++)
        {
            obj2.transform.localScale += new Vector3(0.1f, 0.1f, 0);
            yield return null;
        }
        for (int i = 0; i < 30; i++)
        {
            obj2.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
            yield return null;
        }
        obj2.SetActive(false);
    }

    IEnumerator StandBy1()
    {
        obj1.SetActive(true);
        for (int i = 0; i < 30; i++)
        {
            obj1.transform.localScale += new Vector3(0.1f, 0.1f, 0);
            yield return null;
        }
        for (int i = 0; i < 30; i++)
        {
            obj1.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
            yield return null;
        }
        obj1.SetActive(false);
    }
}
