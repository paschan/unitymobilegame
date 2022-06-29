using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int damage=10;
    public GameObject player;
    private Inventory inv;
    public void increaseDamage(int amount){
       inv=player.GetComponent<Inventory>();
       /*Debug.Log("area start");
       if(inv!=null){
          Debug.Log("area get inv comp");
       }*/
       if(int.Parse(inv.getStrPotionCount())>0){
         this.damage+=amount;
         inv.useStrPotion();
         Debug.Log("Damage:"+damage);
       }
    }
    private GameObject area;
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.GetComponent<Health>() != null){
           Health health = collider.GetComponent<Health>();
           health.Damage(damage);
        }     
   }
   public void endAttack(){
       
   }
   public int getDamage(){
      return damage;
   }
   
}
