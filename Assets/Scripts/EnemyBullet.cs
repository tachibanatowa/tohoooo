using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // 弾の発射スピード
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
        // 上から下に弾を移動
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // 画面下方に消えたら弾を消去
        if (transform.position.y <= shitagenkai)
        {
            Destroy(gameObject);
        }
    }
}
