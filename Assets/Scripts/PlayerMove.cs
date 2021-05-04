using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private int speed = 5;

    [SerializeField]
    private GameObject explosionEffectPrefab;

    public VariableJoystick variableJoystick;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    transform.Translate(Vector3.down * Time.deltaTime);
        //}

        //else if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    transform.Translate(Vector3.up * Time.deltaTime);
        //}

        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime);
        //}

        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.right * Time.deltaTime);
        //}
        //else
        //{

        //}
#if UNITY_EDITOR
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        variableJoystick.gameObject.SetActive(false);
#elif UNITY_ANDROID
        float h = variableJoystick.Horizontal;
        float v = variableJoystick.Vertical;
#endif
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        transform.Translate(dir * speed * Time.deltaTime);

    }

    private void OnDestroy()
    {
        if (this != null)
        {
            Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            print("Player Null");
        }

    }

}
