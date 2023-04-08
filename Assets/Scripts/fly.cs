using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fly : MonoBehaviour
{
    public gameover go;
    public float speed = 1f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            rb.velocity = Vector2.up * speed;
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        go.gameOver();
    }

}
