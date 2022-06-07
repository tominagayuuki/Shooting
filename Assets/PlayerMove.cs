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
        //プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;
        //右矢印きーが入力されたとき
        if (Input.GetKey(KeyCode.RightArrow)){
            //右方向に0.01動く
            pos.x += 0.01f;
        }
        //左矢印きーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左方向に0.01動く
            pos.x -= 0.01f;
        }
        //上矢印きーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //上方向に0.01動く
            pos.z += 0.01f;
        }
        //下矢印きーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //下方向に0.01動く
            pos.z -= 0.01f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
