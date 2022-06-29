using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    private bool canShield=true;
    private bool canTakeDamage=true;
    public GameObject shield;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(canShield);
    }
    public void activateShield(){
        if(canShield){
            StartCoroutine(shieldDuration());
            StartCoroutine(shieldCooldown());
        }        
    }
    IEnumerator shieldDuration(){
        shield.SetActive(true);
        canTakeDamage=false;
        canShield=false;
        yield return new WaitForSeconds(5f);
        shield.SetActive(false);
        canTakeDamage=true;               
    }
    IEnumerator shieldCooldown(){
        yield return new WaitForSeconds(15f);
        canShield=true;            
    }
    public bool getCanTakeDamage(){
        return canTakeDamage;
    }
}
