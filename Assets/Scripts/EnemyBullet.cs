using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //[SerializeField]
    //private GameObject objGet1;

    //private Main1GameDirector objGet1;
    // 弾の発射スピード
    public float Speed;
    float shitagenkai;
   
    //private GameObject _object();

    // Start is called before the first frame update
    void Start()
    {
        //objGet1 = new Main1GameDirector();
        shitagenkai = -5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 上から下に弾を移動
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // 画面下方に消えたら弾を消去
        if (transform.position.y <= shitagenkai)
        {
            Destroy(gameObject);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D col)
    {
        // 敵だったら
        if (col.gameObject.tag == "Player")
        {
            // ぶつかったプレイヤーを破壊
            Destroy(col.gameObject);

            // 敵弾を破壊
            Destroy(gameObject);

            //objGet1.GetComponent<Main1GameDirector>().GameOver();
            GameObject.Find("Main1GameDirector").GetComponent<Main1GameDirector>().GameOver();
        }
    }


}
