using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HpPotionCount : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private TextMeshProUGUI txt;
    private Inventory inv;
    void Start()
    {
        txt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
            inv=player.GetComponent<Inventory>();
            txt.text=inv.getHpPotionCount();
        }
        
    }
}
