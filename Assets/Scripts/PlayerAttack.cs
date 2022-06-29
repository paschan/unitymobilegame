using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;
    //private Collider2D areacolider = default;
    private Rigidbody2D myBody;
    private Animator anim;
    private float attacktime;
    private bool attacking = false;
    private bool canAtck = true;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        anim = GetComponent<Animator>();
    }
    void Awake() {
        myBody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Attack(){
        attacking = true;
        attackArea.SetActive(attacking);
        anim.Play("Attack1");
        
    }
    public void Attacking(){
        if(myBody.velocity.y==0 && canAtck){
            Attack();
        }
                
        //Debug.Log("Attacking");
    }
    public void endAttack(){
        attacking=false;
        attackArea.SetActive(attacking);
        canAtck=true;
        anim.SetBool("Attack",false);
    }
    public void canAttack(){
        canAtck=false;
    }
}
