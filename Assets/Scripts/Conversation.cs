using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conversation : MonoBehaviour
{
    private int count=0;
    public void nextConv(){
        if(count==transform.childCount){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        if(count<transform.childCount){
            transform.GetChild(count).gameObject.SetActive(true);
        
            if(count>0){
                transform.GetChild(count-1).gameObject.SetActive(false);
            }
            Debug.Log(count);
            count++;      
        }
                  
    }
}
