using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public GameObject obj;
    bool isCalled = false;
    Vector3 stg;
    public float posX, posY, posPre, speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(posX, posY, 0);
        Instantiate(obj, new Vector3(posPre, posY, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        stg = transform.position;
        transform.position -= new Vector3(speed, 0, 0);
        if (stg.x < -30.0f && isCalled == false)
        {
            gameObject.SetActive(false);
            isCalled = true;
        }
    }
}
