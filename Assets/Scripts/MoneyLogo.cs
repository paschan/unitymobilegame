using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MoneyLogo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Inventory playerInv;
    private TextMeshProUGUI txt;
    void Start()
    {
        playerInv=player.GetComponent<Inventory>();
        txt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text=playerInv.getMoney();
    }
}
