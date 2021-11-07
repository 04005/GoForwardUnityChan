using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;
    // ���ňʒu
    private float deadLine = -10;

    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name!= "UnityChan") 
        { 
            GetComponent<AudioSource>().Play();
        }
    }
 }

