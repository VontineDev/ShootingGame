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

        //�����Լ��� ����Ͽ� 0~9�ȿ��� int��
        var count = Random.Range(0, 10);

        //30�ۼ�Ʈ�� �÷��̾� ������ �̵�
        if (count < 3)
        {
            //�÷��̾� ã��
            var player = GameObject.Find("Player");

            //���� ���ϱ�
            dir = player.transform.position - dir;
            //������ ũ��1¥�� ���ͷ� �����
            dir = dir.normalized;

        }
        else
        {
            dir = Vector3.down;
        }

        //�������� �Ʒ���
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
