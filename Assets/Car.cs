using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cat : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        // �I������V�s��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); // �������ʡu3�v
        }
        // �I������V�s��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); // ���k���ʡu3�v
        }
    }
}