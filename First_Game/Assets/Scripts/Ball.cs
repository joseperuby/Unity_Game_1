using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameManager gameManager;
    Vector2 startPos;
    AI ronaldo;
    PLA messi;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ronaldo = GameObject.Find("ronaldo").GetComponent<AI>();
        messi = GameObject.Find("messi").GetComponent<PLA>();
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "porteria")
        {
            gameManager.ronaldoScore++;
            transform.position = startPos;
            ronaldo.ResetRonaldo();
            messi.ResetMessi();
            rb.velocity = Vector2.zero;
        }
        else if (collision.gameObject.name == "porteria_2")
        {
            gameManager.messiScore++;
            transform.position = startPos;
            ronaldo.ResetRonaldo();
            messi.ResetMessi();
            rb.velocity = Vector2.zero;
        }
    }
}
