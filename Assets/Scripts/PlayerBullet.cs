using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public delegate void MyEventHandler();
    public　event MyEventHandler EnemyNum;

    // 弾の発射スピード
    public float Speed;
    float uegenkai;

    public int _EnemytoubatuNum=0;

    // Start is called before the first frame update
    void Start()
    {
        uegenkai = 5.0f;
        //_EnemyNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 下から上に弾を移動
        transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;

        // 画面上方に消えたら弾を消去
        if (transform.position.y >= uegenkai)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        // 敵だったら
        if (col.gameObject.tag == "Enemy")
        {
            // ぶつかった相手を破壊
            Destroy(col.gameObject);

            // 弾を破壊
            Destroy(gameObject);

            //EnemyNum();

            //_EnemytoubatuNum++;

            //Debug.Log(_EnemytoubatuNum);
        }
    }

}
