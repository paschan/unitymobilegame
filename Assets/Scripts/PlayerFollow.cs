using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    private Transform playerTransform;
    void Start()
    {
        
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        
    }

    void LateUpdate()
    {
        if(playerTransform!=null){
            Vector3 temp = transform.position;

            temp.x = playerTransform.position.x;

            transform.position=temp;
        }
       

    }
}
