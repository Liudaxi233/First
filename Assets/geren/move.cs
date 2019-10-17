using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour{
    public float moveSpeed = 300;
    public float JumpSpeed = 100;
    Rigidbody2D rig2d;
    // Start is called before the first frame update
    void Start()
    {
        rig2d = transform.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Move();
        Jump();
    }
    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig2d.velocity = new Vector2(rig2d.velocity.x, JumpSpeed);
        }
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rig2d.velocity = new Vector2(h * moveSpeed, rig2d.velocity.y);
    }
}
