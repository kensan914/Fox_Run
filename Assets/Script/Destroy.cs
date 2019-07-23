using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject obj;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = obj.transform.position;
        if (pos.x < -30.0)
        {
            Destroy(obj);
        }
    }
}
