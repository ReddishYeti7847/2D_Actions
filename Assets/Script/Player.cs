using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float d;     //移動方向
    public float speed; //移動速度
    public int jumpcount;   //ジャンプ回数
    public bool isJump; //ジャンプし始めたかどうか

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力(左右のみ)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            d = 1f;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            d = -1f;
        } else
        {
            d = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpcount < 2)
            {
                isJump = true;
            }
        }

        //移動処理
        rb.velocity = new Vector2(speed * d, rb.velocity.y);
        if (isJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, 6f);
            jumpcount++;
            isJump = false;
        }
    }

    public void JumpReset()
    {
        jumpcount = 0;
    }
}
