using UnityEngine;
using UnityEngine.UI;

public class Conversion : MonoBehaviour
{
    InputField IF;
    string S = "";
    int pos = 0;
    int Tpos = 0;
    // Use this for initialization
    void Start()
    {
        IF = gameObject.GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && IF.text != "" && S != IF.text)
        {
            if (S == "")
            {
                if (IF.text.Length > 1 && IF.text.Length % 2 == 0)
                {
                    int cun = IF.text.Length;
                    if (IF.text.Substring(0, cun / 2) == IF.text.Substring(cun / 2, cun / 2))
                    {
                        IF.text = IF.text.Substring(0, cun / 2);
                    }
                }
            }
            else
            {
                if (IF.text.Length - Tpos > 1)
                {

                    if (Tpos + (pos - Tpos) * 2 == IF.text.Length)
                    {

                        string hantei = IF.text.Substring(Tpos);

                        if (hantei.Length > 1 && hantei.Length % 2 == 0)
                        {
                            int cun = hantei.Length;
                            if (hantei.Substring(0, cun / 2) == hantei.Substring(cun / 2, cun / 2))
                            {

                                IF.text = IF.text.Substring(0, Tpos) + hantei.Substring(0, cun / 2);
                            }
                        }
                    }
                    else
                    {
                        Debug.Log((IF.text.Length - (Tpos + (pos - Tpos) * 2)) / 2);
                        int usiro = (IF.text.Length - (Tpos + (pos - Tpos) * 2)) / 2;
                        int mae = Tpos - usiro;
                        string hantei = IF.text.Remove(IF.text.Length - usiro).Substring(mae);
                        if (hantei.Length > 1 && hantei.Length % 2 == 0)
                        {
                            int cun = hantei.Length;
                            if (hantei.Substring(0, cun / 2) == hantei.Substring(cun / 2, cun / 2))
                            {

                                IF.text = IF.text.Substring(0, mae) + hantei.Substring(0, cun / 2) + IF.text.Substring(IF.text.Length - usiro, usiro);
                            }
                        }
                    }
                }

            }
        }
        S = IF.text = IF.text.Trim();
        Tpos = IF.text.Length;
        pos = IF.selectionAnchorPosition;
    }
}
