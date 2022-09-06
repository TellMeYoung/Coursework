using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    [Header("FireBall")]
    [SerializeField] private float offset;
    [SerializeField] private Transform fireballStartPos;
    [SerializeField] private GameObject fireBallPrefab;
    [HideInInspector] public bool isFireBallCd = false;
    public float fireBallCdTime;
    [SerializeField] private FireBallSlider fireBallSlider;

    [Header("LightningBolt")]
    [SerializeField] private GameObject lightningBoltPrefab;
    [HideInInspector] public bool isLightningBoltCd = false;
    public float lightningBoltCdTime;
    [SerializeField] private LightningBoltSlider lightningBoltSlider;


    void Update()
    {


        if (Input.GetKeyDown("1") && !isFireBallCd)
        {
            fireBallSlider.slider.value = 1;
            isFireBallCd = true;
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            fireballStartPos.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
            Instantiate(fireBallPrefab, fireballStartPos.position, fireballStartPos.rotation);

        }

        if (Input.GetKeyDown("2") && !isLightningBoltCd)
        {
            lightningBoltSlider.slider.value = 1;
            isLightningBoltCd = true;
           Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(lightningBoltPrefab, mousePos, Quaternion.Euler(0, 0, 0));

        }

    }

 
}
