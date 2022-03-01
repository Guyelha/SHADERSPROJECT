using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRenderer;
    bool powerTime;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(powerTime)
        meshRenderer.material.SetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b",meshRenderer.material.GetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b"+0.03f));
        if (meshRenderer.material.GetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b") >= 5)
            powerTime = false;
       
        if (powerTime)
            meshRenderer.material.SetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b", meshRenderer.material.GetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b") - 0.03f);
        if (meshRenderer.material.GetFloat("Vector1_322fe91e7b1e4db4b6f2235fee2aa56b") <= 5)
            powerTime = true;
    }
}
