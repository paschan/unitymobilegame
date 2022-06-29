using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShieldCooldown : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI txt;
    private int cooldownmax=15;
    private int cooldown=15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startCooldown(){
        if(cooldown==cooldownmax){
            
            transform.gameObject.SetActive(true);
            txt=GetComponent<TextMeshProUGUI>();
            txt.text=cooldown.ToString();
            StartCoroutine(Cooldown());
            StopCoroutine("Cooldown");        
        } 
    }
    IEnumerator Cooldown(){
        while(cooldown>0){
            yield return new WaitForSeconds(1f);
            cooldown--;
            txt.text=cooldown.ToString();
        }
        cooldown=cooldownmax;
        transform.gameObject.SetActive(false);
    }
}
 

