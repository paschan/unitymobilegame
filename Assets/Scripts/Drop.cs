using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject gameobj;
    public GameObject hpPotion;
    public GameObject strPotion;
    public GameObject player;
    private Inventory playerInv;
    private int hpPotionChance=60;
    private int strPotionChance=30;
    
    void Start()
    {
        gameobj= GetComponent<GameObject>();
        playerInv=player.GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void droped(){
        //Debug.Log("drop");
        
        int roll = Random.Range(0,100);
        Debug.Log(roll+":Roll");
        /*Debug.Log(!strPotion.activeSelf+":strpotionactive");
        Debug.Log(strPotion!=null);*/
        if(roll<strPotionChance&&strPotion!=null){
            //strPotion.SetActive(true);
            //Rigidbody2D strBody = strPotion.GetComponent<Rigidbody2D>();
            //strBody.AddForce(new Vector2(Random.Range(-1f,1f),Random.Range(0f,1f)));
            //Debug.Log("stractive");
            //strPotion.gameObject.transform.position=transform.position;
            //strPotion.transform.position=transform.position;
            Instantiate (strPotion,transform.position,Quaternion.identity);
        }
        else if (roll<hpPotionChance&&hpPotion!=null){
            //hpPotion.SetActive(true);
            //Rigidbody2D hpBody=hpPotion.GetComponent<Rigidbody2D>();
            //hpBody.AddForce(new Vector2(Random.Range(-1f,1f),Random.Range(0f,1f)));
            //hpPotion.gameObject.transform.position=transform.position;
            //hpPotion.transform.position=transform.position;
            Instantiate (hpPotion,transform.position,Quaternion.identity);
        }
        playerInv.earnMoney();

    }
    
}
