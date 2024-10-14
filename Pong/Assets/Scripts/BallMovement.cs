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
        int randomIndex = Random.Range(0, 8);
        float angle = randomIndex * 45f * Mathf.Deg2Rad;
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        rb2d.AddForce(direction * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
