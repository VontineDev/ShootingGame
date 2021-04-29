using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //Using for Random.Range
    [SerializeField]
    float minTime = 1;
    [SerializeField]
    float maxTime = 5;

    //present time
    private float timePassed = 0;

    //set time
    [SerializeField]
    private float timeScheduled = 1.5f;
    //enemy Prefab
    [SerializeField]
    private GameObject enemyPrefab;




    // Start is called before the first frame update
    void Start()
    {
        //set timeScheduled Randomly
        timeScheduled = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {

        //time passes
        timePassed += Time.deltaTime;


        //if time passed
        if (timePassed >= timeScheduled)
        {
            //create enemy
            //set position
            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = this.transform.position;

            timePassed = 0;

            //set timeScheduled again Randomly
            timeScheduled = Random.Range(minTime, maxTime);
            //Debug.Log($"{this.gameObject.name} : {timeScheduled}");

        }

    }
}
