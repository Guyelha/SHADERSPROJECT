using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
  
    {
        if (other.GetComponent<CharacterStats>())
        {

            other.GetComponent<CharacterStats>().HP -= 20;
            Destroy(gameObject);

        }
    }
}
