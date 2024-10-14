using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.velocity = new Vector2(0, speed);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.velocity = new Vector2(0, speed *-1);
        } 
        else 
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        } 
    }
}
