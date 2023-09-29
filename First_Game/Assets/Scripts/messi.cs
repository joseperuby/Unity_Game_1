using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position = new Vector3(transform.position.x + .05f,
                                            transform.position.y, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.position = new Vector3(transform.position.x - .05f,
                                            transform.position.y, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.position = new Vector3(transform.position.x + .05f,
                                            transform.position.y, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.position = new Vector3(transform.position.x - .05f,
                                            transform.position.y, 0);
        }
    }
}
