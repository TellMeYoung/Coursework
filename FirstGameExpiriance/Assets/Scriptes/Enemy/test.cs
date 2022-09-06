using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float agrRange;
    [SerializeField] private float stopDistance;
    private CircleCollider2D circleCollider;
    private Transform target;
    private bool chill = false;
    private bool angry = false;

    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.radius = 0.12f;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        chill = false;
        angry = true;
    }

    private void OnTriggerExit2d(Collider2D hitInfo)
    {
        chill = true;
        angry = false;
    }

    private void Angry()
    {
        if (Vector2.Distance(transform.position, target.position) > stopDistance)
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }

    private void Chill()
    {
     
    }

    void Update()
    {
        if (chill)
        {
            Chill();
        }

        if (angry)
        {
            Angry();
        }

    }
}
