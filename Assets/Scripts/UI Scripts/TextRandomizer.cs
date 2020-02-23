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
        paperText.text = "“One cannot step twice in the same river.” - Heraclitus";
    }
}
