using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // �e�̔��˃X�s�[�h
    public float Speed;
    float shitagenkai;

    // Start is called before the first frame update
    void Start()
    {
        shitagenkai = -5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // �ォ�牺�ɒe���ړ�
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // ��ʉ����ɏ�������e������
        if (transform.position.y <= shitagenkai)
        {
            Destroy(gameObject);
        }
    }
}
