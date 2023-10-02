using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineUpToSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.FindGameObjectWithTag("Cube");
        GameObject cylinder = GameObject.FindGameObjectWithTag("Cylinder");
        cube.transform.position = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
        cylinder.transform.position = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
    }
}
