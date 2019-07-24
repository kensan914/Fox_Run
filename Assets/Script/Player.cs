using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float row = 1;
    Vector3 ply;
    Coroutine retC;
    public bool isPoison;
    bool isCalled;
    IEnumerator PE;

    Texture2D screenTexture;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-6.5f, -1.35f, 1);
        gameObject.GetComponent<Renderer>().sortingOrder = 32;
        PE = PoisonEffect();
    }

    public void Awake()
    {
        screenTexture = new Texture2D(1, 1, TextureFormat.ARGB32, false);
    }

    // Update is called once per frame
    void Update()
    {

        switch (row)
        {
            case 0:
                if ((!isPoison && Input.GetKeyDown(KeyCode.DownArrow)) || isPoison && Input.GetKeyDown(KeyCode.UpArrow))
                {
                    StartCoroutine("From0To1");
                }
                break;
            case 1:
                if ((!isPoison && Input.GetKeyDown(KeyCode.UpArrow)) || isPoison && Input.GetKeyDown(KeyCode.DownArrow))
                {
                    StartCoroutine("From1To0");
                }
                else if ((!isPoison && Input.GetKeyDown(KeyCode.DownArrow)) || isPoison && Input.GetKeyDown(KeyCode.UpArrow))
                {
                    StartCoroutine("From1To2");
                }
                break;
            case 2:
                if ((!isPoison && Input.GetKeyDown(KeyCode.UpArrow)) || isPoison && Input.GetKeyDown(KeyCode.DownArrow))
                {
                    StartCoroutine("From2To1");
                }
                break;
            default:
                break;
        }
        if (isPoison & !isCalled)
        {
            isCalled = true;
            retC = StartCoroutine(PE);
            StartCoroutine("CountSec");
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
        if ((!isPoison && Input.GetKey(KeyCode.DownArrow)) || isPoison && Input.GetKey(KeyCode.UpArrow))
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
        if ((!isPoison && Input.GetKey(KeyCode.DownArrow)) || isPoison && Input.GetKey(KeyCode.UpArrow))
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
        if ((!isPoison && Input.GetKey(KeyCode.UpArrow)) || isPoison && Input.GetKey(KeyCode.DownArrow))
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
        if ((!isPoison && Input.GetKey(KeyCode.UpArrow)) || isPoison && Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine("From1To0");
        }
    }

    IEnumerator PoisonEffect()
    {
        float hueVal = 0;
        float bulueVal = 0;
        float redVal = 0;
        float blackVal = 0;
        int changeVal = 3;
        while (true)
        {
            GetComponent<Renderer>().material.SetFloat("_Hue", hueVal);
            hueVal += changeVal;
            if (hueVal > 100)
            {
                changeVal = -3;
            } else if (hueVal < 10)
            {
                changeVal = 3;
            }

            if (bulueVal < 0.3f)
            {
                bulueVal += 0.005f;
                blackVal += 0.005f;
                redVal += 0.001f;
                screenTexture.SetPixel(0, 0, new Color(redVal, 0, bulueVal, blackVal));
                screenTexture.Apply();
            }
            yield return null;
        }
    }
    IEnumerator CountSec()
    {
        while (isPoison)
        {
            yield return null;
        }
        isCalled = false;
        StopCoroutine(PE);
        PE = null;
        PE = PoisonEffect();
        GetComponent<Renderer>().material.SetFloat("_Hue", 0.0f);
    }

    public void OnGUI()
    {
        if (isPoison)
        {
            GUI.DrawTexture(Camera.main.pixelRect, screenTexture);
        }
    }
}
