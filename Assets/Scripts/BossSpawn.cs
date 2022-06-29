using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossSpawn : MonoBehaviour
{
    public GameObject boss;
    public GameObject healthbar;
    public GameObject enemies;
    //public GameObject spell;
    void Update() {
        if(enemies!=null){
            if(enemies.activeSelf){

            }
            else{
                if(boss!=null){
                    boss.SetActive(true);
                    healthbar.SetActive(true);
                }                
                //spell.SetActive(true);
            }
        }
        if(transform.childCount==0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }    
    }

}
