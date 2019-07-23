using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public int layer;
    public bool isPrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().sortingOrder = layer;
        switch (layer)
        {
            case 6:
                if (isPrefab) transform.position = new Vector3(13, 2.3f, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 1);
                break;
            case 8:
                if (isPrefab) transform.position = new Vector3(13, 2.4f, 0);
                transform.localScale = new Vector3(3.0f, 3.0f, 1);
                break;
            case 7:
                if (isPrefab) transform.position = new Vector3(13, 0.4f, 0);
                transform.localScale = new Vector3(4.5f, 4.5f, 1);
                break;
            case 9:
                if (isPrefab) transform.position = new Vector3(13, 0.4f, 0);
                transform.localScale = new Vector3(6.0f, 6.0f, 1);
                break;
            case 10:
                if (isPrefab) transform.position = new Vector3(13, 4.0f, 0);
                transform.localScale = new Vector3(10.0f, 9.0f, 1);
                break;
            case 12:
                if (isPrefab) transform.position = new Vector3(13, 4.0f, 0);
                transform.localScale = new Vector3(12.0f, 11.0f, 1);
                break;
            case 40:
                if (isPrefab) transform.position = new Vector3(13, -5.6f, 0);
                transform.localScale = new Vector3(13.0f, 11.0f, 1);
                break;
            case 42:
                if (isPrefab) transform.position = new Vector3(13, -5.5f, 0);
                transform.localScale = new Vector3(15.0f, 12.0f, 1);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (layer)
        {
            case 6:
            case 7:
                transform.position -= new Vector3(0.09f, 0, 0);
                break;
            case 8:
            case 9:
                transform.position -= new Vector3(0.1f, 0, 0);
                break;
            case 10:
                transform.position -= new Vector3(0.2f, 0, 0);
                break;
            case 12:
                transform.position -= new Vector3(0.22f, 0, 0);
                break;
            case 40:
                transform.position -= new Vector3(0.2f, 0, 0);
                break;
            case 42:
                transform.position -= new Vector3(0.21f, 0, 0);
                break;
            default:
                break;
        }
    }
}
