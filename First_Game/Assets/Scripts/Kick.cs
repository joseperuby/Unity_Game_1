using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float force = 10f;
    public GameObject ball;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        rb = ball.GetComponent<Rigidbody2D>();
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Vector2 pos = (transform.position - collision.gameObject.transform.position).normalized;
            rb.AddForce(-pos * force, ForceMode2D.Impulse);
        }
    }
}
