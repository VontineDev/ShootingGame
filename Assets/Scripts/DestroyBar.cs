using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(collision.gameObject);

    //}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }
}
