using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    private float move = 5f;
    private bool isJumping;
    Rigidbody2D rb;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        //float move = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(speed * move, rb.velocity.y);
        rb.MovePosition(rb.position + movement * move * Time.fixedDeltaTime);
        /*  if(move < 0)
          {
              transform.eulerAngles = new Vector3(0, 180, 0);
          }else if (move > 0)
          {
              transform.eulerAngles = new Vector3(0, 0, 0);
          }
          if (Input.GetButtonDown("Jump") && !isJumping)
          {
              rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
              isJumping = true;
          }
      }*/
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
