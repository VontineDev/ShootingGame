using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private GameObject missilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If you push Fire1 button, Excute PlayerFire Method
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        var missile = Instantiate(missilePrefab); //Instantitate missile
        missile.transform.position = this.transform.position + new Vector3(0, 0.9f, 0); //set missile position as player's head

        //missile.transform.SetParent(this.transform);  //set missile's parent player
    }
}
