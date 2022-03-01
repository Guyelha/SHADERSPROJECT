using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPregeneration : MonoBehaviour
{
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
       if(other.GetComponent<CharacterStats>())
        {
           print("Trigger works");
            other.GetComponent<CharacterStats>().HP += 20;

        }
    }
}
