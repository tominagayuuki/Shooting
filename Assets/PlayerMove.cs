using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        //�v���C���[�̃��[���h���W���擾
        Vector3 pos = transform.position;
        //�E��󂫁[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.RightArrow)){
            //�E������0.01����
            pos.x += 0.01f;
        }
        //����󂫁[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //��������0.01����
            pos.x -= 0.01f;
        }
        //���󂫁[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //�������0.01����
            pos.z += 0.01f;
        }
        //����󂫁[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //��������0.01����
            pos.z -= 0.01f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
