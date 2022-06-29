using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarlockSpell : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private Rigidbody2D myBody;
    private Animator anim;
    private Health targetHealth;
    private BoxCollider2D coll;
    [SerializeField] int damage=15;
    private float ySize=0;
    void Start()
    {
        
    }
    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        if(transform.gameObject.activeSelf){
            anim.Play("WarlockSpell");
        }
    }

    // Update is called once per frame
    void Update()
    {   
        /*Vector2 pos = new Vector2(target.transform.position.x,target.transform.position.y+1.45f);
        transform.position=pos;*/
    }
    public void hide(){
        transform.gameObject.SetActive(false);
    }
    public void getTargetPos(){
        Vector2 pos = new Vector2(target.transform.position.x,target.transform.position.y+1.38f);
        transform.position=pos;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if(col.tag=="Player"){
            targetHealth = col.GetComponent<Health>();
            targetHealth.Damage(damage);
        }
    }
    public void increseCollider(){
        coll.size = new Vector2(coll.size.x, ySize);
        ySize=ySize+0.1f;
    }
    public void increse2Collider(){
        coll.size = new Vector2(coll.size.x, ySize);
        ySize=ySize+0.2f;
    }
    public void increse3Collider(){
        coll.size = new Vector2(coll.size.x, ySize);
        ySize=ySize+0.3f;
    }
    public void resetColider(){
        this.ySize=0.1f;
        coll.size = new Vector2(coll.size.x, ySize);
    }
        
}
