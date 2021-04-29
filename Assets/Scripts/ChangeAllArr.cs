using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAllArr : MonoBehaviour
{
    public int[] numArr = new int[46];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //call ChangeAllNumArr();
            ChangeAllNumArr();

            string allNum = "";

            for (int i = 0; i < numArr.Length; i++)
            {
                //string + int
                allNum = allNum + numArr[i];

                allNum = allNum + " ";
            }

            print(allNum);

        }
    }

    void ChangeAllNumArr()
    {

        int index1;
        int index2;
        while (true)
        {
            index1 = Random.Range(0, 46);
            index2 = Random.Range(0, 46);

            if (index1 == index2)
            {
                break;
            }
            Swap(index1, index2);
        }
    }
    void Swap(int index1, int index2)
    {
        int temp = numArr[index1];

        numArr[index1] = numArr[index2];
        numArr[index2] = temp;
    }
}
