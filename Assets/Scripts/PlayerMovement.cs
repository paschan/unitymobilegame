using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;
    private Animator anim;
    private FixedJoystick joystick;
    public GameObject shield;
    

    private bool canRun;
    //private bool canAttack;
    private bool canJump;
    private bool canShield;


    private float speed=8f;
    private float maxVelocity = 4f;
    private float jumpspeed = 8f;
    void Awake()
    {
        myBody=GetComponent<Rigidbody2D>();
        joystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
        anim = GetComponent<Animator>();
        //canAttack= true;
        canRun=true;
        canJump=true;
        
    }
    // Update is called once per frame
    void Update()
    {
        PlayerRun();
        JumpCheck();
        
    }
    void FixedUpdate(){

    }
    public void Jump(){
        if(canJump){
            myBody.velocity=new Vector3(0f,jumpspeed);
            canJump=false;
        }        
    }
    void JumpCheck(){
        if(myBody.velocity.y==0){
            canJump=true;
        }
        if(myBody.velocity.y>0.1){
            anim.Play("Jump");
        }
        else if ( myBody.velocity.y<(-0.1)){
            anim.Play("Fall");
        }
    }    
    void PlayerRun(){
        var force =0f;
        var velocity = Mathf.Abs(myBody.velocity.x);
        float h = joystick.Horizontal;
        //Debug.Log(h);
        /*if(Input.touchCount==0){
            myBody.velocity=new Vector3(0f,myBody.velocity.y);
        }*/
        if(canRun){
            if(h>0){
            if(velocity<maxVelocity ){
                force=speed;
            }
            Vector3 scale = transform.localScale;
            scale.x=3;
            transform.localScale=scale;
            anim.SetBool("Run",true);
        }
        else if(h<0){
            if(velocity < maxVelocity ){
                force=-speed;
            }
            Vector3 scale = transform.localScale;
            scale.x=-3;
            transform.localScale=scale;
            anim.SetBool("Run",true);
        }
        else if (h==0){
            anim.SetBool("Run",false);
            myBody.velocity=new Vector3(0f,myBody.velocity.y);
        }
        myBody.AddForce(new Vector2(force,0));
        }        
    }
    
}
