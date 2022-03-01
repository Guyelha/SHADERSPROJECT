using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CharacterStats>())
        {
            other.GetComponent<CharacterStats>().HP +=40;
            Destroy(gameObject);
        }
    }
}
