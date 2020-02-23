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
       
        paperText.text = "A drop of water doesn't kill you, and you won't drown in a bucket...";
    }
}
