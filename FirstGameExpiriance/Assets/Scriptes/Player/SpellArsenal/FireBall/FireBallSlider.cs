using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireBallSlider : MonoBehaviour
{
    public Slider slider;
    public Spell spell;
    void Start()
    {
        slider.maxValue = 1;
        slider.value = 0;

    }
    void Update()
    {


        if (spell.isFireBallCd)
        {

            if (slider.value > 0)
            {
                slider.value -= 1 / spell.fireBallCdTime * Time.deltaTime;

            }
            else { spell.isFireBallCd = false; slider.value = 0; }

        }

    }

   
}
