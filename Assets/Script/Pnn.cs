using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using System.Text.RegularExpressions;

public class Pnn : MonoBehaviour
{
    private static int pnn;
    public Text pnnText;

    void Start()
    {
        pnn = 0;
        pnnText.text = "-";
        StartCoroutine("LoadCsv");
    }

    void Update()
    {
        pnnText.text = pnn.ToString() + "%";
    }

    public static int GetPnn()
    {
        return pnn;
    }

    IEnumerator LoadCsv()
    {
        while (true)
        {
            FileInfo fi = new FileInfo(Application.dataPath + "/Resources/" + "pNN50.txt");
            try
            {
            }
            catch (Exception e)
            {
                
            }
            using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8))
            {
                string newSr = Regex.Replace(sr.ReadToEnd(), @"[^0-9.]", "");
                string newSr2 = newSr.Substring(0, 5);
                float newSr3 = float.Parse(newSr2) * 100;
                pnn = (int)newSr3;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
