using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private int speed = 3;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {

        //랜덤함수를 사용하여 0~9안에서 int값
        var count = Random.Range(0, 10);

        //30퍼센트를 플레이어 쪽으로 이동
        if (count < 3)
        {
            //플레이어 찾기
            var player = GameObject.Find("Player");

            //방향 구하기
            dir = player.transform.position - dir;
            //방향을 크기1짜리 벡터로 만들기
            dir = dir.normalized;

        }
        else
        {
            dir = Vector3.down;
        }

        //나머지는 아래로
    }

    // Update is called once per frame
    void Update()
    {
        //Move down with speed
        transform.Translate(dir * speed * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.transform.tag!="Dest")
        // Destroy other
        Destroy(collision.gameObject);
        // Destroy self
        Destroy(this.gameObject);

    }
}
