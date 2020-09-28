using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryPrefabMove : MonoBehaviour
{
    int row;
    bool rockStay=false;
    public bool isFox;
    Vector3 pos;
    private Animator animator;
    GameObject TF;
    bool isCalled;
    GameObject gen;
    Generator script;
    public AudioClip ninjaSound;
    AudioSource audioSouce;

    // Start is called before the first frame update
    void Start()
    {
        gen = GameObject.Find("Administrator");
        script = gen.GetComponent<Generator>();
        gameObject.SetActive(true);
        row = Random.Range(0, 3);
        switch (row)
        {
            case 0:
                transform.localScale = new Vector3(5, 5, 1);
                transform.position = new Vector3(12, -0.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 31;
                break;
            case 1:
                if (!script.magicDoing)
                {
                    transform.localScale = new Vector3(6, 6, 1);
                    transform.position = new Vector3(12, -1.95f, 0);
                    gameObject.GetComponent<Renderer>().sortingOrder = 32;
                }
                else
                {
                    transform.localScale = new Vector3(6, 6, 1);
                    transform.position = new Vector3(12, -1.95f, 0);
                    gameObject.GetComponent<Renderer>().sortingOrder = 32;
                    Destroy(gameObject);
                }
                break;
            case 2:
                transform.localScale = new Vector3(7, 7, 1);
                transform.position = new Vector3(12, -3.2f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 33;
                break;
            default:
                break;
        }
        if (isFox)
        {
            animator = GetComponent<Animator>();
            TF = GameObject.Find("transformEffect");
            audioSouce = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rockStay == false) {
            pos = gameObject.transform.position;
            transform.position -= new Vector3(0.1f, 0, 0);


            if (script.getLevel()<=5 && isFox && pos.x < 0)
            {
                if (!isCalled)
                { 
                    switch (row)
                    {
                        case 0:
                            transform.localScale = new Vector3(-7.2f, 7.2f, 1);
                            transform.position = new Vector3(0, -0.32f, 0);
                            break;
                        case 1:
                            transform.localScale = new Vector3(-8, 8, 1);
                            transform.position = new Vector3(0, -1.35f, 0);
                            break;
                        case 2:
                            transform.localScale = new Vector3(-8.8f, 8.8f, 1);
                            transform.position = new Vector3(0, -2.47f, 0);
                            break;
                        default:
                            break;
                    }
                    audioSouce.PlayOneShot(ninjaSound);
                    GetComponent<Renderer>().material.SetFloat("_Sat", 0.4f);
                    animator.SetBool("transform", true);
                    TF.GetComponent<TransformEffect>().setTransform();
                    isCalled = true;
                }
            }else if(script.getLevel() == 6 && isFox && pos.x < -2)
            {
                if (!isCalled)
                {
                    switch (row)
                    {
                        case 0:
                            transform.localScale = new Vector3(-7.2f, 7.2f, 1);
                            transform.position = new Vector3(-2, -0.32f, 0);
                            break;
                        case 1:
                            transform.localScale = new Vector3(-8, 8, 1);
                            transform.position = new Vector3(-2, -1.35f, 0);
                            break;
                        case 2:
                            transform.localScale = new Vector3(-8.8f, 8.8f, 1);
                            transform.position = new Vector3(-2, -2.47f, 0);
                            break;
                        default:
                            break;
                    }
                    audioSouce.PlayOneShot(ninjaSound);
                    GetComponent<Renderer>().material.SetFloat("_Sat", 0.4f);
                    animator.SetBool("transform", true);
                    TF.GetComponent<TransformEffect>().setTransform();
                    isCalled = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock tag" && gameObject.GetComponent<Renderer>().sortingOrder == other.gameObject.GetComponent<Renderer>().sortingOrder)
        {
            rockStay = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock tag" && gameObject.GetComponent<Renderer>().sortingOrder == other.gameObject.GetComponent<Renderer>().sortingOrder)
        {
            rockStay = false;
        }
    }
}
