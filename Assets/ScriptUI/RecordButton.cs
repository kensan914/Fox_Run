using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordButton : MonoBehaviour
{
    GameObject rankingForm;
    RankingForm script;

    // Start is called before the first frame update
    void Start()
    {
        rankingForm = GameObject.Find("rankingForm");
        script = rankingForm.GetComponent<RankingForm>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        script.UpdateRanking();
        SceneManager.LoadScene("Ranking");
    }
}
