using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int count=0;
    void Update(){
        
        if(count!=transform.childCount-1){
            if(!transform.GetChild(count).gameObject.activeSelf){
                count++;
                transform.GetChild(count).gameObject.SetActive(true);
                Debug.Log(count);    
                if(count==transform.childCount-1){
                    transform.gameObject.SetActive(false);
                }        
            }
        }    
    }
    void Awake() {
        transform.GetChild(0).gameObject.SetActive(true);
    }    
    
}
