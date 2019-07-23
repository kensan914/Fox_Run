using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryPrefabMove : MonoBehaviour
{
    int row;
    bool rockStay=false;

    // Start is called before the first frame update
    void Start()
    {
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
                transform.localScale = new Vector3(6, 6, 1);
                transform.position = new Vector3(12, -1.95f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 32;
                break;
            case 2:
                transform.localScale = new Vector3(7, 7, 1);
                transform.position = new Vector3(12, -3.2f, 0);
                gameObject.GetComponent<Renderer>().sortingOrder = 33;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rockStay == false) {
            transform.position -= new Vector3(0.1f, 0, 0);
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
