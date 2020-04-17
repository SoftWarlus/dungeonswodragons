using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



public class PlayerController : MonoBehaviour
{
    const int STATE_IDLE = 0;
    const int STATE_WALK = 1;

    public float moveSpeed;
    public float motionX;
    public float motionY;
    public int facing = 1; // 1 = right, -1 = left
    public float jumpSpeed;
    private bool isJumping;

    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        motionX = Input.GetAxisRaw("Horizontal");
        motionY = Input.GetAxisRaw("Vertical");
        if (motionX > 0.5f || motionX < -0.5f)
        {
            setFacing(motionX);
            changeState(STATE_WALK);
            transform.Translate(new Vector2(motionX * moveSpeed * Time.deltaTime, 0f));
        }

        if (motionY > 0.5f || motionY < -0.5f)
        {
            changeState(STATE_WALK);
            transform.Translate(new Vector2(0f, motionY * moveSpeed * Time.deltaTime));
        }

        if (motionY < 0.5f && motionY > -0.5f && motionX < 0.5f && motionX >  -0.5f)
        {
            changeState(STATE_IDLE);
        }
    }

    void setFacing(float direction)
    {
        if (facing*direction < 0)
        {
            if (direction > 0.5f)
            {
                sr.flipX = false;
                facing = 1;
            }
            if (direction < 0.5f)
            {
                sr.flipX = true;
                facing = -1;
            }
        }
    }

    void changeState(int state)
    {
        if (anim.GetInteger("state") != state)
        {
            anim.SetInteger("state", state);
        }
    }
}
