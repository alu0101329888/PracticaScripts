using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CubeArrayScript : MonoBehaviour
{
    int maxRandomNumber;
    int minRandomNumber;
    List<int> array;

    public int threshold;
    public int arraySize;

    // Start is called before the first frame update
    void Start()
    {
        minRandomNumber = 0;
        maxRandomNumber = 25;
        array = new List<int>(arraySize);
        for (int i = 0; i < arraySize; i++) {
            array.Add(Random.Range(minRandomNumber, maxRandomNumber + 1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        array[Random.Range(0, array.Count - 1)] = Random.Range(minRandomNumber, maxRandomNumber + 1);
        foreach (int i in array) {
            if (i > threshold) {
                print(i);
            }
        }

    }
}
