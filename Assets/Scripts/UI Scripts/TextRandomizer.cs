using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextRandomizer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI paperText;
    public List<string> list;


    void Awake()
    {
       

        int num = Random.Range(1,4);
        switch (num)
        {
            case 1:
                paperText.text = "Pyyhi kakkainen aanuksesi tällä senkin hetero :D -memegod";
                break;
            case 2:
                paperText.text = "aaaa tsajajaajajajaa shalaaa";
                break;
            case 3:
                paperText.text = "Dropletto sama doenst kill you and thee shall'nt've' drown in bucket";
                break;
            case 4:
                paperText.text = "Ei >:(";
                break;
        }
        //paperText.text = "“One cannot step twice in the same river.” - Heraclitus";
    }
}
