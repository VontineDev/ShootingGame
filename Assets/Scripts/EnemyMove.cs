using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move down with speed
        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");

        // Destroy other
        Destroy(collision.gameObject);
        // Destroy self
        Destroy(this.gameObject);


    }
}
