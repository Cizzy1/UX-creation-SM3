using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSlider : MonoBehaviour
{
    public Slider slider;
    public TMP_Text SliderText;

    public void UpdateSlider(){
        if(slider.value == 0){
            SliderText.text = "OFF";
        }else{
            SliderText.text = slider.value.ToString("0") + "%";
        }
    }

}
