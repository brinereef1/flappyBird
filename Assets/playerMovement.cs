using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;
    public float rotationSpeed;
    private float horizon;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal");

        if (horizon > 0)
            body.velocity = new Vector2(speed, body.velocity.y);
            if (Input.GetKey(KeyCode.S))
                 transform.Rotate(new Vector3(0, 0, -rotationSpeed));
            else if (Input.GetKey(KeyCode.W))
                 transform.Rotate(new Vector3(0, 0, rotationSpeed));

        else if (horizon < 0)
            body.velocity = new Vector2(speed * horizon, body.velocity.y);
            if (Input.GetKey(KeyCode.S))
                transform.Rotate(new Vector3(0, 0, -rotationSpeed));
            else if (Input.GetKey(KeyCode.W))
                transform.Rotate(new Vector3(0, 0, rotationSpeed));

        else if (Input.GetKey(KeyCode.W))
            transform.Rotate(new Vector3(0, 0, rotationSpeed));

        else if (Input.GetKey(KeyCode.S))
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));


    }   
}
