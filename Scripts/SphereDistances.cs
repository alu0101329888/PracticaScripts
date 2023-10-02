using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDistances : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.FindGameObjectWithTag("Cube");
        GameObject cylinder = GameObject.FindGameObjectWithTag("Cylinder");
        print("Distance between cube and cylinder: " + Vector3.Distance(cube.GetComponent<Transform>().position, cylinder.GetComponent<Transform>().position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
