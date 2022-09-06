using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField]private int damage;



    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
  
        if (!(hitInfo.CompareTag("Player")) && hitInfo.gameObject.TryGetComponent(out IDamageable damageable))
        {
            damageable.ApplyDamage(damage);
            this.GetComponent<Animator>().Play("Boom");
            rb.velocity = transform.right * 0;
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        }

    }

}

