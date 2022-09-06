using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Spots")]
    [SerializeField] private Transform[] moveSpots;
    [SerializeField] private Transform _transform;

   private int nextSpot = 0;
    private int spotCount;

    private float waitTime;
    [SerializeField] private float startWaitTime;

    [Header("Parametrs")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float agrRange;
    [SerializeField] private float stopDistance;
    private CircleCollider2D circleCollider;
    private Transform target;
    private bool chill = false;
    private bool angry = false;
    void Start()
    {
        chill = true;
        spotCount = moveSpots.Length - 1;
        waitTime = startWaitTime;
        target = GameObject.FindGameObjectWithTag("Player").transform;
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


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            chill = false;
        angry = true;
        Debug.Log("Trigger Angry ");
        }
    }

    private void OnTriggerExit2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player") { 
        chill = true;
        angry = false;
        Debug.Log("Trigger Chill");
        }
    }

    void Chill()
    {


        _transform.position = Vector2.MoveTowards(_transform.position, moveSpots[nextSpot].position, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(_transform.position, moveSpots[nextSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                if (nextSpot != spotCount) nextSpot++; else nextSpot = 0;


                waitTime = startWaitTime;

            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }





    }

    private void Angry()
    {
        if (Vector2.Distance(_transform.position, target.position) > stopDistance)
            _transform.position = Vector2.MoveTowards(_transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}