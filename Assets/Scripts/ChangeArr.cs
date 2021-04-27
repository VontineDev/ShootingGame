using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArr : MonoBehaviour
{
    public int[] arr = { 0, 1, 2, 3, 4 };

    // Start is called before the first frame update
    void Start()
    {
        PrintArr();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeArray(0, 2);

            PrintArr();
        }
    }
    void ChangeArray(int index1, int index2)
    {
        if (arr == null || arr.Length <= index2)
        {
            return;
        }
        int temp = arr[index1];

        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
    void PrintArr()
    {
        foreach (int n in arr)
        {
            Debug.Log(n);
        }
    }

}
