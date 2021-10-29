using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private object score;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int n = 4; n > -1; n--)
        {
            Debug.Log(array[n]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}