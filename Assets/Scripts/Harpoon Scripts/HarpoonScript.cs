﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonScript : MonoBehaviour
{

    //speed of the harpoon
    public float speed = 5f;

    public float deactivate_Timer = 3f;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("DeactivateGameObject", deactivate_Timer);

    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }

    void Move()
    {

        Vector3 temp = transform.position;

        temp.y -= speed * Time.deltaTime;

        transform.position = temp;

    }

    void DeactivateGameObject()
    {

        gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        
        if(target.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }

    }
}
