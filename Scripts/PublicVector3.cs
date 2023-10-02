using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVector3 : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;

    // Start is called before the first frame update
    void Start()
    {
        print("1st vector's magnitude: " + vector1.magnitude);
        print("2nd vector's magnitude: " + vector2.magnitude);
        print("Angle between the two vectors: " + Vector3.Angle(vector1, vector2));
        print("Distance between the two vectors: " + Vector3.Distance(vector1, vector2));
        if (vector1.y >= vector2.y) {
            print("Vector with highest y: vector1");
        } else {
            print("Vector with highest y: vector2");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
