using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightningBoltSlider : MonoBehaviour
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
        

            if (spell.isLightningBoltCd)
        {

            if (slider.value > 0)
            {
                slider.value -= 1/spell.lightningBoltCdTime * Time.deltaTime;

            }
            else { spell.isLightningBoltCd = false; slider.value = 0; }

        }

    }

   
}
