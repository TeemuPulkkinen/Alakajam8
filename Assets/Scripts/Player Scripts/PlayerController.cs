using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    //Speed of the player
    public float speed = 5f;

    //Maximum and Minimum boundaries for the player movement
    public float min_X, max_X;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();


    }

    void MovePlayer()
    {

        if(Input.GetAxisRaw("Horizontal") > 0f)
        {

            Vector3 temp = transform.position;

            temp.x += speed * Time.deltaTime;

            if (temp.x > max_X)
            {
                temp.x = max_X;
            }

            transform.position = temp;

        } else if (Input.GetAxisRaw("Horizontal") < 0f)
        {

            Vector3 temp = transform.position;

            temp.x -= speed * Time.deltaTime;

            if (temp.x < min_X)
            {
                temp.x = min_X;
            }

            transform.position = temp;

        }

    }
}
