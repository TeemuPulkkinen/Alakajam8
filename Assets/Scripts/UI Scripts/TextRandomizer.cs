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
                paperText.text = "“If there is magic on this planet, it is contained in water.” - Loren Eiseley";
                break;
            case 2:
                paperText.text = "“One cannot step twice in the same river.” - Heraclitus";
                break;
            case 3:
                paperText.text = "“Water is the driving force of all nature.” - Leonardo da Vinci";
                break;
            case 4:
                paperText.text = "“Nothing is softer or more flexible than water, yet nothing can resist it.” - Lao Tzu";
                break;
        }
        //paperText.text = "“One cannot step twice in the same river.” - Heraclitus";
    }
}
