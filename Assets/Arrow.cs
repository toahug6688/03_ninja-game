using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Arrow : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        // ��b�Y�W�X�C���e���ɴN�˱󪫥�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
