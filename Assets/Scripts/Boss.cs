using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spell;
    public GameObject attackArea;
    private Animator anim;
    private bool canCast,canAttack,animCast,animAttack,canWalk;
    public GameObject target;
    private Vector3 newVector;
    private float speed=1f;
    private Rigidbody2D myBody;
    private Health health;
    private bool haveTurned,rightFlag,leftFlag;
    void Start()
    {
        anim=GetComponent<Animator>();
        canCast= true;  
        canAttack =true; 
        animAttack=true;
        animCast=true;   
        canWalk=true; 
        myBody=GetComponent<Rigidbody2D>();
        health=GetComponent<Health>();
        haveTurned=false;
        newVector = target.transform.position-transform.position;
        if(newVector.x<0){
            leftFlag=true;
            rightFlag=false;
        }
        if(newVector.x>0){
            rightFlag=true;
            leftFlag=false;
        }
    }
    // Update is called once per frame
    void Update()
    {   
        if(health.getHealth()>0){
            //Debug.Log(newVector.x);
            if(target!=null && transform!=null){
                newVector = target.transform.position-transform.position;
            }
            if(newVector.x<-2 && rightFlag==true){
                haveTurned=true;
                //Debug.Log("have turned");
                leftFlag=true;
                rightFlag=false;
            }
            if(newVector.x>2 && leftFlag==true){
                haveTurned=true;
                //Debug.Log("have turned");
                rightFlag=true;
                leftFlag=false;
            }

            //Debug.Log(canWalk);  
            //Debug.Log(canAttack); 
            //Debug.Log(canCast); 
            if(canCast && (newVector.x<5 && newVector.x>-5) && animCast){
                anim.Play("Cast");
                //Debug.Log("cancast working");
                canCast=false;            
            }
            if(canAttack && (newVector.x<3 && newVector.x>-3) && animAttack){
                anim.Play("Attack");
                //Debug.Log("canattack working");
                canAttack=false;            
            }
            if(canWalk){
                //Debug.Log(newVector.x);
                if(newVector.x>2){
                    Vector3 scale = transform.localScale;
                    //Vector2 pos = new Vector2(transform.position.x+3f,transform.position.y);
                    //transform.position=pos;
                    scale.x=4.5f;
                    transform.localScale=scale;
                    myBody.velocity= new Vector2(speed,0);
                    anim.Play("Walk");
                    if(haveTurned){
                        transform.position= new Vector2(transform.position.x+3f,transform.position.y);
                        haveTurned=false;
                    }
                    
                }
                if(newVector.x<-2){
                    Vector3 scale = transform.localScale;
                    scale.x=-4.5f;
                    //Vector2 pos = new Vector2(transform.position.x-3f,transform.position.y);
                    //transform.position=pos;
                    transform.localScale=scale;
                    myBody.velocity= new Vector2(-speed,0);
                    anim.Play("Walk");
                    if(haveTurned){
                        transform.position= new Vector2(transform.position.x-3f,transform.position.y);
                        haveTurned=false;
                    }
                }  
                if(newVector.x<1 && newVector.x>-1){
                    anim.SetBool("Walk",false);
                }   
            }       

        }   
        //Debug.Log(newVector.x);
    }
    public void castSpell(){
        spell.SetActive(true);
    }
    public void ableToCastAgain(){
        StartCoroutine(spellCoolDown());
    }
    IEnumerator spellCoolDown(){
        yield return new WaitForSeconds(10f);
        canCast=true;       
    }
    public void attack(){
        attackArea.SetActive(true);
    }
    public void disableAttackArea(){
        attackArea.SetActive(false);
    }
    public void ableToAttackAgain(){
        StartCoroutine(attackCoolDown());
    }
    IEnumerator attackCoolDown(){
        yield return new WaitForSeconds(5f);
        canAttack=true;       
    }
    public void disableCast(){
        canWalk=false;
        animCast=false;
    }
    public void disableAttack(){
        animAttack=false;
        canWalk=false;
    }
    public void enableCast(){
        animCast=true;
        canWalk=true;
    }
    public void enableAttack(){
        animAttack=true;
        canWalk=true;
    }
    
}
