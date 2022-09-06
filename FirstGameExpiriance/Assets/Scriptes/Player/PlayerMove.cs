using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    [Header("Parametrs")]
    [SerializeField] private float speed = 0.1f;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        walk();

    }

    private void walk()
    {

        rb.MovePosition(rb.position + direction * speed);

    }
}
