using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform otherObject;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
       
            


    }


    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.D))
        {
            speed = -5;
        } else if (Input.GetKey(KeyCode.D))
        {
            speed = 5;
        } else
        {
            speed = 0;
        }
        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);
    }
}
