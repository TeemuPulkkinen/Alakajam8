using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float speed = 5f;
    public float rotate_Speed = 50f;

    public bool canShoot;
    public bool canRotate;
    private bool canMove = true;

    public float bound_Y = -11f;

    public Transform attack_Point;
    public GameObject enemy_Harpoon;

    private Animator anim;
    private AudioSource destroySound;

    // Start is called before the first frame update
    void Awake()
    {

        anim = GetComponent<Animator>();
        destroySound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        
    }

    void Move()
    {

        if (canMove)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;

            if(temp.y < bound_Y)
            {
                gameObject.SetActive(false);
            }
        } 

    }
}
