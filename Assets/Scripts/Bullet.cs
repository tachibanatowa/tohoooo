using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 弾の発射スピード
    public float Speed;
    float uegenkai;

    // Start is called before the first frame update
    void Start()
    {
        uegenkai = 5.0f;
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
}
