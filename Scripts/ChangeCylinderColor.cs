using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCylinderColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            GetComponent<Renderer>().material.color = new Color(25, 60, 0);
        }
    }
}
