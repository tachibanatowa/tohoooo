using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    // 弾のプレハブ
    public GameObject enemybulletPrefab;

    public float Speed;     // 速度
    private float pointY;   // プレイヤーに向かってくるY軸の位置
    private float vx;           // X軸の移動量
    private GameObject player;  // プレイヤーオブジェクト取得用

    private float _destroyPosY = -5.5f;


    //一定間隔での連射用
    private float timeReset;
    private float time;

    // Start is called before the first frame update
    void Start()
    {

        Speed = 5.0f;

        // プレイヤーに向かってくるY軸の位置
        pointY = Random.Range(2.0f, 3.0f);
        // 敵の初期位置とプレイヤーの位置によってX軸の移動方向を決定する（プレイヤーに向かってくるような設定）
        vx = 1.0f;
        player = GameObject.FindGameObjectWithTag("Player");
        if (player.transform.position.x < transform.position.x)
        {
            vx = -vx;
        }

        //初期値設定
        time = 0;
        timeReset = 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        // 下に向かって移動する
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // 一定の位置になるとプレイヤーに向かって移動する
        if (transform.position.y < pointY)
        {
            transform.position += new Vector3(vx, 0, 0) * Time.deltaTime;
        }

        // 画面の下に消えたらオブジェクト消去
        if (transform.position.y < _destroyPosY)
        {
            Destroy(this.gameObject);
        }

        //---銃の弾--
        //一定時間で射出準備可能に
        time += Time.deltaTime;
        if (time >= timeReset)
        {

            Instantiate(enemybulletPrefab, transform.position, Quaternion.identity);
            time = 0;
        }

    }


}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyMover : MonoBehaviour
//{
//    public float Speed = 0.05f;
//    private Transform _transform;

//    // 初期化.
//    public void Initialize(Transform transform)
//    {
//        _transform = transform;
//    }

//    // 移動更新
//    public void UpdateMove()
//    {
//        if (_transform != null)
//        {
//            _transform.Translate(0, -0.01f, 0);
//        }

//    }

//    // 座標取得
//    public Vector3 GetPosition()
//    {
//        return _transform.position;
//    }
//} 

