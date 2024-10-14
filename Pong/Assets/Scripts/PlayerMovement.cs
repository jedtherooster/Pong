using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0, speed);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0, speed *-1);
        } 
        else 
        {
            rb2d.velocity = new Vector2(0, 0);
        } 
    }
}
