using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBolt : MonoBehaviour
{
    [SerializeField] private int damage;
    void Start()
    {
        this.GetComponent<Animator>().Play("LightningBolt");
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (!(hitInfo.CompareTag("Player")) && hitInfo.gameObject.TryGetComponent(out IDamageable damageable)) damageable.ApplyDamage(damage);
    }
}
