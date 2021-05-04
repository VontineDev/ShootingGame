using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareArr : MonoBehaviour
{
    public int[] arr;


    // Start is called before the first frame update
    void Start()
    {
        arr = new int[5] { 3, 0, 8, 4, 5 };
        int[] values = Check(arr);

        for (int i = 0; i < values.Length; i++)
        {
            print(values[i] + " ");
        }
    }


    public int[] Check(int[] arr)
    {
        int[] resultArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (j < 0)
                    break;
                if (arr[i] < arr[j])
                {
                    resultArr[i] = j + 1;
                    break;
                }
            }
        }
        return resultArr;
    }

}
