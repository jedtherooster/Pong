using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] private float speed = 400f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(20*Time.deltaTime * speed,20*Time.deltaTime * speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
