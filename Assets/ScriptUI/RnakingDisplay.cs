using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RnakingDisplay : MonoBehaviour
{
    string[] nameKey = { "n1", "n2", "n3", "n4", "n5", "n6", "n7", "n8", "n9", "n10" };
    string[] scoreKey = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
    public Text n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
    /*
    Text n1 = GameObject.Find("n1").GetComponent<Text>();
    Text n2 = GameObject.Find("n2").GetComponent<Text>();
    Text n3 = GameObject.Find("n3").GetComponent<Text>();
    Text n4 = GameObject.Find("n4").GetComponent<Text>();
    Text n5 = GameObject.Find("n5").GetComponent<Text>();
    Text n6 = GameObject.Find("n6").GetComponent<Text>();
    Text n7 = GameObject.Find("n7").GetComponent<Text>();
    Text n8 = GameObject.Find("n8").GetComponent<Text>();
    Text n9 = GameObject.Find("n9").GetComponent<Text>();
    Text n10 = GameObject.Find("n10").GetComponent<Text>();
    Text s1 = GameObject.Find("s1").GetComponent<Text>();
    Text s2 = GameObject.Find("s2").GetComponent<Text>();
    Text s3 = GameObject.Find("s3").GetComponent<Text>();
    Text s4 = GameObject.Find("s4").GetComponent<Text>();
    Text s5 = GameObject.Find("s5").GetComponent<Text>();
    Text s6 = GameObject.Find("s6").GetComponent<Text>();
    Text s7 = GameObject.Find("s7").GetComponent<Text>();
    Text s8 = GameObject.Find("s8").GetComponent<Text>();
    Text s9 = GameObject.Find("s9").GetComponent<Text>();
    Text s10 = GameObject.Find("s10").GetComponent<Text>();
    */
   
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey(nameKey[0]))
        {
            n1.text = PlayerPrefs.GetString(nameKey[0], null);
        }
        if (PlayerPrefs.HasKey(nameKey[1]))
        {
            n2.text = PlayerPrefs.GetString(nameKey[1], null);
        }
        if (PlayerPrefs.HasKey(nameKey[2]))
        {
            n3.text = PlayerPrefs.GetString(nameKey[2], null);
        }
        if (PlayerPrefs.HasKey(nameKey[3]))
        {
            n4.text = PlayerPrefs.GetString(nameKey[3], null);
        }
        if (PlayerPrefs.HasKey(nameKey[4]))
        {
            n5.text = PlayerPrefs.GetString(nameKey[4], null);
        }
        if (PlayerPrefs.HasKey(nameKey[5]))
        {
            n6.text = PlayerPrefs.GetString(nameKey[5], null);
        }
        if (PlayerPrefs.HasKey(nameKey[6]))
        {
            n7.text = PlayerPrefs.GetString(nameKey[6], null);
        }
        if (PlayerPrefs.HasKey(nameKey[7]))
        {
            n8.text = PlayerPrefs.GetString(nameKey[7], null);
        }
        if (PlayerPrefs.HasKey(nameKey[8]))
        {
            n9.text = PlayerPrefs.GetString(nameKey[8], null);
        }
        if (PlayerPrefs.HasKey(nameKey[9]))
        {
            n10.text = PlayerPrefs.GetString(nameKey[9], null);
        }
        if (PlayerPrefs.HasKey(scoreKey[0]))
        {
            s1.text = PlayerPrefs.GetInt(scoreKey[0], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[1]))
        {
            s2.text = PlayerPrefs.GetInt(scoreKey[1], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[2]))
        {
            s3.text = PlayerPrefs.GetInt(scoreKey[2], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[3]))
        {
            s4.text = PlayerPrefs.GetInt(scoreKey[3], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[4]))
        {
            s5.text = PlayerPrefs.GetInt(scoreKey[4], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[5]))
        {
            s6.text = PlayerPrefs.GetInt(scoreKey[5], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[6]))
        {
            s7.text = PlayerPrefs.GetInt(scoreKey[6], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[7]))
        {
            s8.text = PlayerPrefs.GetInt(scoreKey[7], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[8]))
        {
            s9.text = PlayerPrefs.GetInt(scoreKey[8], 0).ToString();
        }
        if (PlayerPrefs.HasKey(scoreKey[9]))
        {
            s10.text = PlayerPrefs.GetInt(scoreKey[9], 0).ToString();
        }
    }
}