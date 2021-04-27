using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private int speed = 5;
    [SerializeField]
    private GameObject missilePrefab;

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

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * h + Vector3.up * v;

        transform.Translate(dir * speed * Time.deltaTime);

        // If you push Fire1 button, Excute PlayerFire Method
        if (Input.GetButton("Fire1"))
        {
            PlayerFire();
        }
    }

    void PlayerFire()
    {
        var missile = Instantiate(missilePrefab); //Instantitate missile
        missile.transform.position = this.transform.position; //set missile position as player position
        missile.transform.SetParent(this.transform);  //set missile's parent player
    }

}