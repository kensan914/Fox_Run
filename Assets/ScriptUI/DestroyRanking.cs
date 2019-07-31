using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRanking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log(PlayerPrefs.HasKey("s1"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
