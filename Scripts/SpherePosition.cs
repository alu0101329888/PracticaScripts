using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Sphere's position: " + GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
