using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // 敵のプレハブ
    public GameObject enemyPrefab;

    private float _shokiXmainasu = -2.8f;
    private float _shokiXpurasu = 2.8f;

    private float _syokiY = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // 敵をランダムに生成
        if (Random.Range(0, 300) == 1)
        {
            Vector3 pos = new Vector3(Random.Range(_shokiXmainasu, _shokiXpurasu), _syokiY, 0);  // 画面上方に生成
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        }
    }
}



