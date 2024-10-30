using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameManager gameManager;
    public int life = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �P�_�I�����I���馳�S���a�����ҡuArrow�v
        if (collision.gameObject.tag == "Arrow")
        {
            gameManager.DecreaseHp();
            life -= 1;
            if (life <= 0)
                Destroy(gameObject);
        }
    }

    // ���a���U�e��������ɡA�߫}�������ʡu3�v
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    // ���a���U�e���k����ɡA�߫}���k���ʡu3�v
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}