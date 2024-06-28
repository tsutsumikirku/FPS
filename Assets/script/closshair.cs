using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closshair : MonoBehaviour
{

    [SerializeField] GameObject bom;
    [SerializeField] GameObject bom2;
    [SerializeField] float ti;
    float time;
    void Start()
    {
        // マウスカーソルを消す
        Cursor.visible = false;
        time = ti;
    }

    void Update()
    {
     
        // Camera.main でメインカメラ（MainCamera タグの付いた Camera）を取得する
        // Camera.ScreenToWorldPoint 関数で、スクリーン座標をワールド座標に変換する
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;    // Z 座標がカメラと同じになっているので、リセットする
        this.transform.position = mousePosition;


        //射撃
        time += Time.deltaTime;
        if (Input.GetButton("Fire1") && time > ti)
        {
            Instantiate(bom);
            Instantiate(bom2).transform.position = this.gameObject.transform.position;
            time = 0;
        }
        
    }
     

}
