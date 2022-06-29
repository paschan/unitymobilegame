using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int hpPotionCount;
    public int strPotionCount;
    public int money=50;
    void Start()
    {
        hpPotionCount=0;
        strPotionCount=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.GetComponent<HpPotion>() != null){
            Destroy(collider.gameObject);
            hpPotionCount++;

        }
        else if (collider.GetComponent<StrPotion>()!=null){
            Destroy(collider.gameObject);
            strPotionCount++;
        }
    }
    public void addDrop(GameObject loot){
        
    }
    public string getHpPotionCount(){
        return hpPotionCount.ToString();
    }
    public string getStrPotionCount(){
        return strPotionCount.ToString();
    }
    public void useHpPotion(){
        this.hpPotionCount--;
    }
    public void useStrPotion(){
        this.strPotionCount--;
    }
    public void buyHpPotion(){
        if(money>=10){
            this.hpPotionCount++;
            this.money=this.money-10;
        }
    }
    public void buyStrPotion(){
        if(money>=15){
            this.strPotionCount++;
            this.money=this.money-15;
        }
    }
    public string getMoney(){
        return money.ToString();
    }
    public void earnMoney(){
        this.money=this.money+5;
    }
}
