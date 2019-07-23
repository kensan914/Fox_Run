using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public GameObject obj;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(obj, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
