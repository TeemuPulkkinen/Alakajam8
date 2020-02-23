using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{
    
    public string TreasureChest;

    //public const float Timer_Time = 5F;

    public float TimerTime = 5F;

    
    private float time = 0F;
    
    void Update()
    {
        
        this.time += Time.deltaTime;

        
        if (this.time >= TimerTime)
        {
            SceneManager.LoadScene(TreasureChest);
        }
    }
}
