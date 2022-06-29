using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Slider slider;
   public void setMaxHealth(int maxhealt){
       slider.maxValue=maxhealt;
       slider.value=maxhealt;
   } 
   public void setHealth(int health){
       slider.value=health;
   }
}
