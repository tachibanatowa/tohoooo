using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private GameObject objGet2;

    // プレイヤーの移動速度
    public float _Speed ;

    // 弾のプレハブ
    public GameObject playerbulletPrefab;

    ////上下左右の壁座標用
    float _xleft;
    float _xright;
    float _yue;
    float _yshita;
    //上下左右の壁bool用
    bool _xleftbool;
    bool _xrightbool;
    bool _yuebool;
    bool _yshitabool;

    //一定間隔での連射用
    private float timeReset;
    private float time;


    // Start is called before the first frame update
    void Start()
    {


        //壁の数値を設定する
        _yue = 4.75f ;
        _yshita = -4.75f;
        _xright = 2.7f;
        _xleft = -2.7f;

        //初期値設定
        time = 0;
        timeReset = 0.1f;

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;

        if (pos.y <= _yue)
        {
            _yuebool = true;
        }
        else
        {
            _yuebool = false;
        }

        if (pos.y >= _yshita)
        {
            _yshitabool = true;
        }
        else
        {
            _yshitabool = false;
        }

        ////
        if (pos.x <= _xright)
        {
            _xrightbool = true;
        }
        else
        {
            _xrightbool = false;
        }

        if (pos.x >= _xleft)
        {
            _xleftbool = true;
        }
        else
        {
            _xleftbool = false;
        }

        if ((Input.GetKey(KeyCode.W)))
        {
            if (_yuebool)
            {
             pos.y =pos.y + _Speed;
            }

        }

        if (Input.GetKey(KeyCode.A))
        {
            if (_xleftbool)
            {
                pos.x = pos.x - _Speed;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (_yshitabool)
            {
                pos.y = pos.y - _Speed;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (_xrightbool)
            {
                pos.x = pos.x + _Speed;
            }
        }

        // 現在位置にx,y の値を加算する
        this.transform.position = pos;


        //---銃の弾--
        //一定時間で射出準備可能に
        time += Time.deltaTime;
        if (time > timeReset)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(playerbulletPrefab, this.transform.position, Quaternion.identity);
                time = 0;
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        // 敵だったら
        if (col.gameObject.tag == "Enemy")
        {
            // ぶつかった敵を破壊
            Destroy(col.gameObject);

            // Playerを破壊
            Destroy(gameObject);

            //objGet2.GetComponent<Main1GameDirector>().GameOver();
            GameObject.Find("Main1GameDirector").GetComponent<Main1GameDirector>().GameOver();
        }
    }


}