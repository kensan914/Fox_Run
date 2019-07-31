using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecessionPrefab : MonoBehaviour
{
    public GameObject obj;
    public int layer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver.GetisGameOver())
        {
            switch (layer)
            {
                case 1:
                    obj.transform.position -= new Vector3(0.05f, 0, 0);
                    break;
                case 4:
                    obj.transform.position -= new Vector3(0.02f, 0, 0);
                    break;
                case 6:
                    obj.transform.position -= new Vector3(0.01f, 0, 0);
                    break;
                case 7:
                    obj.transform.position -= new Vector3(0.01f, 0, 0);
                    break;
                case 10:
                    obj.transform.position += new Vector3(0.1f, 0, 0);
                    break;
                case 12:
                    obj.transform.position += new Vector3(0.12f, 0, 0);
                    break;
                case 39:
                    obj.transform.position -= new Vector3(0.1f, 0, 0);
                    break;
                case 40:
                    obj.transform.position += new Vector3(0.1f, 0, 0);
                    break;
                case 42:
                    obj.transform.position += new Vector3(0.11f, 0, 0);
                    break;
            }
        }
    }
}
