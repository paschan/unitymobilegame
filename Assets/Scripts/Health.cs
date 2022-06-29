using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
    
    private int MAX_HEALTH;
    private Animator anim;
    private BoxCollider2D coll;
    private Rigidbody2D mBody;
    [SerializeField]private int health=100;
    public HealthBar healthbar;
    private Rigidbody2D myBody;
    private bool canTakeDamage;
    private Shield shield;
    private Drop drop;
    private Inventory inv;
    public int getHealth(){
        return health;
    }
    void Awake(){
        MAX_HEALTH=health;
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        myBody= GetComponent<Rigidbody2D>();
        if(healthbar!=null){
            healthbar.setMaxHealth(MAX_HEALTH);
        }
        myBody=GetComponent<Rigidbody2D>();
        canTakeDamage=true;
        if(transform.gameObject.GetComponent<Shield>()!=null){
            shield=GetComponent<Shield>();
        }
        if(transform.gameObject.GetComponent<Drop>()!=null){
            drop=GetComponent<Drop>();
            //Debug.Log("comp");
        }
        if(transform.gameObject.GetComponent<Inventory>()!=null){
            inv=GetComponent<Inventory>();
        }
        //playerMove=GetComponent<PlayerMovement>();s
    }
    void Update()
    {
        if(shield!=null){
            //Debug.Log(shield.getCanTakeDamage());
        }
    }
    public void Damage(int amount){
        //float vel=myBody.velocity.y;
        if(shield!=null){
            canTakeDamage=shield.getCanTakeDamage();
        }
        
        Vector3 scale = transform.localScale;
        if(canTakeDamage){
            if(GetComponent<Boss>()==null){
            //Debug.Log(vel);
                if(health>0){
                    if(scale.x<0){
                        transform.position=transform.position + new Vector3(2f,0,0);
                        //myBody.AddForce(new Vector2(5,0));
                    }
                    else if (scale.x>0){
                        //myBody.AddForce(new Vector2(-5,0));
                        transform.position=transform.position + new Vector3(-2f,0,0);
                    }
                } 
                if(health>0){
                    anim.Play("TakeHit");
                    
                }  
            }        
            if(amount<0){
                throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
            }
            this.health-=amount;
            if(healthbar!=null){
                healthbar.setHealth(this.health);
            }
            
                       
            if(health<=0){
                anim.Play("Death");
                //myBody.constraints = RigidbodyConstraints2D.FreezePosition;
                //Die();
            }
        }
        
    }
    public void Heal(int amount){
        if(int.Parse(inv.getHpPotionCount())>0){
                if(amount<0){
                throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");
            }
            if(health!=MAX_HEALTH){

            
                if(health+amount>MAX_HEALTH && healthbar!=null){
                    this.health=MAX_HEALTH;
                    healthbar.setHealth(this.health);
                    inv.useHpPotion();
                }
                else{
                    this.health+=amount;
                    inv.useHpPotion();
                    if(healthbar!=null){
                        healthbar.setHealth(this.health);
                    }
                    
                }
            }
        }        
    }
    public void Die(){
        Destroy(gameObject);
        
        if(healthbar!=null){
                healthbar.gameObject.SetActive(false);
        }
        
        //gameObject.SetActive(false);
    }
    public void disableObj(){
        gameObject.SetActive(false);
        
    }
    public void disableCollider(){
        myBody.constraints = RigidbodyConstraints2D.FreezePosition;
        coll.enabled=false;
        
    }
}
