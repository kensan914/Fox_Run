using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float row = 1;
    Vector3 ply;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-6.5f, -1.35f, 1);
        gameObject.GetComponent<Renderer>().sortingOrder = 32;
        //gameObject.layer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        switch (row)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    StartCoroutine("From0To1");
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    StartCoroutine("From1To0");
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    StartCoroutine("From1To2");
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    StartCoroutine("From2To1");
                }
                break;
            default:
                break;
        }
    }

    IEnumerator From0To1()
    {
        row = 0.5f;
        gameObject.GetComponent<Renderer>().sortingOrder = 32;
        ply = gameObject.transform.position;
        while (ply.y > -1.28f)
        {
            ply = gameObject.transform.position;
            transform.position -= new Vector3(0.009f, 0.064f, 0);
            transform.localScale += new Vector3(0.05f, 0.05f, 0);
            yield return null;
        }
        row = 1;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine("From1To2");
        }
    }

    IEnumerator From1To0()
    {
        row = 0.5f;
        gameObject.GetComponent<Renderer>().sortingOrder = 31;
        ply = gameObject.transform.position;
        while (ply.y < -0.4f)
        {
            ply = gameObject.transform.position;
            transform.position += new Vector3(0.009f, 0.064f, 0);
            transform.localScale -= new Vector3(0.05f, 0.05f, 0);
            yield return null;
        }
        row = 0;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine("From0To1");
        }
    }

    IEnumerator From1To2()
    {
        row = 1.5f;
        gameObject.GetComponent<Renderer>().sortingOrder = 33;
        ply = gameObject.transform.position;
        while (ply.y > -2.4f)
        {
            ply = gameObject.transform.position;
            transform.position -= new Vector3(0.009f, 0.07f, 0);
            transform.localScale += new Vector3(0.05f, 0.05f, 0);
            yield return null;
        }
        row = 2;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            StartCoroutine("From2To1");
        }
    }

    IEnumerator From2To1()
    {
        row = 1.5f;
        gameObject.GetComponent<Renderer>().sortingOrder = 32;
        ply = gameObject.transform.position;
        while (ply.y < -1.45f)
        {
            ply = gameObject.transform.position;
            transform.position += new Vector3(0.009f, 0.07f, 0);
            transform.localScale -= new Vector3(0.05f, 0.05f, 0);
            yield return null;
        }
        row = 1;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            StartCoroutine("From1To0");
        }
    }

}
