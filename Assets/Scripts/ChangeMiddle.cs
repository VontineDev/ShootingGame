using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMiddle : MonoBehaviour
{

    string tempA = "NewDeal";
    string tempB = "Deal";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            string middleWord = PickMiddleWords(tempA);

            print(middleWord);

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            string middleWord = PickMiddleWords(tempB);

            print(middleWord);
        }
    }
    string PickMiddleWords(string word)
    {
        string result = "";
        if (word.Length % 2 == 1)
        {
            //print((word.Length / 2) + 1);
            result = word[word.Length / 2].ToString();
        }
        else
        {
            result = word.Substring((word.Length / 2) - 1, 2);
        }
        return result;
    }
}
