using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public float HP = 100;
    public float maxHP = 100;
    public Text HPText;
    public int Coins = 0;
    public Text CoinsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HP = Mathf.Clamp(HP , 30, maxHP);
        HPText.text ="HP:" + Mathf.RoundToInt (HP).ToString();
        CoinsText.text = " Coins: " + Coins.ToString();
    }
}
