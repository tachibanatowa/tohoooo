using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // ’e‚Ì”­ËƒXƒs[ƒh
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
        // ã‚©‚ç‰º‚É’e‚ğˆÚ“®
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // ‰æ–Ê‰º•û‚ÉÁ‚¦‚½‚ç’e‚ğÁ‹
        if (transform.position.y <= shitagenkai)
        {
            Destroy(gameObject);
        }
    }
}
