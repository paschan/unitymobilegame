using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DamageLogo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject atckArea;
    private TextMeshProUGUI txt;
    private AttackArea attackArea;
    void Start()
    {
        attackArea = atckArea.GetComponent<AttackArea>();
        txt=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text=attackArea.getDamage().ToString();
    }
}
