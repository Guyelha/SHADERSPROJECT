using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CollectCoins : MonoBehaviour
{
    public int Coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterStats>())
        {
           
            other.GetComponent<CharacterStats>().Coins += 1;
            Destroy(gameObject);

        }
    }

}
