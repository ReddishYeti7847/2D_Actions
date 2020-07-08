using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float d;     //移動方向
    public float speed; //移動速度
    public bool isJump;    //ジャンプしたかどうか

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if (Input.GetKey(KeyCode.Space))
        {
            isJump = true;
        }

        //移動処理(左右のみ)
        rb.velocity = new Vector2(speed * d, rb.velocity.y);
        if (isJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f);
            isJump = false;
        }
    }
}
