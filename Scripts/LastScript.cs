using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LastScript : MonoBehaviour
{
    GameObject[] spheres;
    int maxSphere;

    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("Group2");
        GameObject cube = GameObject.FindGameObjectWithTag("Cube");
        Vector3 distances = new Vector3(Vector3.Distance(cube.GetComponent<Transform>().position, spheres[0].GetComponent<Transform>().position), Vector3.Distance(cube.GetComponent<Transform>().position, spheres[1].GetComponent<Transform>().position), Vector3.Distance(cube.GetComponent<Transform>().position, spheres[2].GetComponent<Transform>().position));
        float[] distance = { distances[0], distances[1], distances[2] };
        maxSphere = distance.ToList().IndexOf(distance.Max());
        int minSphere = distance.ToList().IndexOf(distance.Min());
        spheres[minSphere].transform.position = new Vector3(spheres[minSphere].transform.position.x, spheres[minSphere].transform.position.y + 1, spheres[minSphere].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            spheres[maxSphere].GetComponent<Renderer>().material.color = new Color(70, 0, 70);
        }
    }
}
