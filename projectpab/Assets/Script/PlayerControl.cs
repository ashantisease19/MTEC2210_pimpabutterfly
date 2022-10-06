using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform otherObject;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
       
            


    }


    // Update is called once per frame
    void Update()
    {
        //float xMove = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A))
        {
            speed = -10;
        } else if (Input.GetKey(KeyCode.D))
        {
            speed = 10;
        } else
        {
            speed = 0;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
