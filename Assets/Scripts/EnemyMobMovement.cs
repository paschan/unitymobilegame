using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMobMovement : MonoBehaviour
{
    private float speed=2f;
    private float force;

    public GameObject target;

    private Health health;
    private Health targetHealth;
    private Rigidbody2D myBody;
    private Vector3 newVector;
    void Start()
    {
        
        
    }
    void Awake(){
        myBody=GetComponent<Rigidbody2D>();
        health=GetComponent<Health>();
        int i = Random.Range(0,2);
        if(i==0){
            Vector2 pos = new Vector2(Random.Range(-24f,-20f),-3.6f);
            transform.position=pos;
            //var rotationVector = transform.rotation.eulerAngles;
            //rotationVector.y = 180;
            //transform.rotation = Quaternion.Euler(rotationVector);
            //Vector3 scale = transform.localScale;
            //scale.x=3;
            //transform.localScale=scale;
            //force=speed;
            
        }
        else if(i==1){
            Vector2 pos = new Vector2(Random.Range(20f,26f),-3.6f);
            transform.position=pos;
            //var rotationVector = transform.rotation.eulerAngles;
            //rotationVector.y = 0;
            //transform.rotation = Quaternion.Euler(rotationVector);
            //Vector3 scale = transform.localScale;
            //scale.x=-3;
            //transform.localScale=scale;
            //force=-speed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health.getHealth()<0){
            myBody.velocity= new Vector2(0,0);
        }
        /*else{
            myBody.velocity= new Vector2(force,0);
        }*/
        if(target!=null && transform!=null){
           newVector = target.transform.position-transform.position;
        }        
        if(newVector.x>0.5){
            myBody.velocity= new Vector2(speed,0);
            Vector3 scale = transform.localScale;
            scale.x=3;
            transform.localScale=scale;
        }
        else if(newVector.x<-0.5){
            Vector3 scale = transform.localScale;
            scale.x=-3;
            transform.localScale=scale;
            myBody.velocity= new Vector2(-speed,0);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if(col.tag=="Player"){
            targetHealth = col.GetComponent<Health>();
            targetHealth.Damage(10);
        }
    }
}
