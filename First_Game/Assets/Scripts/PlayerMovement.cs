using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLA : MonoBehaviour
{
    public float jumpForce;
    public float speed = 4;
    public bool isGrounded = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D)) 
        { 
            MoveRight();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void MoveLeft()
    {
        Vector2 targetPos = new Vector2(transform.position.x - 1, transform.position.y);
        transform.position = Vector2.Lerp(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void MoveRight()
    {
        Vector2 targetPos = new Vector2(transform.position.x + 1, transform.position.y);
        transform.position = Vector2.Lerp(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void Jump()
    {
        if (isGrounded == true) 
        {
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            isGrounded = true;
        }
    }
}
