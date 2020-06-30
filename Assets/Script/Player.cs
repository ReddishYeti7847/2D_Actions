using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 4.0f; //移動速度

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力(左右のみ)
        var h = Input.GetAxis("Horizontal");

        //移動処理(左右のみ)
        Vector2 direction = new Vector2(h, 0).normalized;   //移動する向きの作成
        GetComponent<Rigidbody2D>().velocity = direction * speed;   //移動する向きとスピードを代入
    }
}
