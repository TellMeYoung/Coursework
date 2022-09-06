using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour 
{
    public Vector2 direction;
    public Animator anim;
    public Transform parent;
    void Start()
    {
        anim = GetComponent<Animator>();
        this.transform.position = parent.transform.position;
    }


    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {

        anim.SetFloat("moveX", Mathf.Abs(direction.x));
        anim.SetFloat("moveY", Mathf.Abs(direction.y));
        ReFlect();
    }
    


    public bool faceRight = true;

     void ReFlect()
     {
         if ((direction.x > 0 && !faceRight) || (direction.x < 0 && faceRight))
         {
            transform.Rotate(0f, 180, 0f);
             faceRight = !faceRight;

         }
         

     }
  
}