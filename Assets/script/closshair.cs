using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    [SerializeField] GameObject bom;
    [SerializeField] GameObject bom2;
    [SerializeField] float ti;
    [SerializeField] float ti2;
    [SerializeField] float ti3;
    [SerializeField] float stickSpeed = 5.0f; // スティックの速度調整用
    [SerializeField] Text score;
    [SerializeField] GameObject aA;
    static int scoree;
   
    float time;
    float time2;
    bool isVibrating = false;
    bool useMouse = true; // true: マウス, false: スティック
    bool click = false;
    Vector3 lastMousePosition;

    void Start()
    {
        scoree = 0;
        // マウスカーソルを消す
        Cursor.visible = false;
        time = ti;
        lastMousePosition = Input.mousePosition;
    }

    void Update()
    {
        PlayerPrefs.SetInt("Score", scoree);
        PlayerPrefs.Save();

        Vector3 newPosition = transform.position;

        // マウスの移動検出
        if (Input.mousePosition != lastMousePosition)
        {
            useMouse = true;
        }

        // スティックの入力検出
        var gamepad = Gamepad.current;
        if (gamepad != null)
        {
            Vector2 stickInput = gamepad.leftStick.ReadValue();
            if (stickInput != Vector2.zero)
            {
                useMouse = false;
            }
        }

        if (useMouse)
        {
            // マウスの位置を取得して、ワールド座標に変換する
            newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPosition.z = 0;
        }
        else if (gamepad != null)
        {
            // コントローラーの入力を取得する
            Vector2 stickInput = gamepad.leftStick.ReadValue();
            Vector3 stickMovement = new Vector3(stickInput.x, stickInput.y, 0) * stickSpeed * Time.deltaTime;
            newPosition += stickMovement;
        }

        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(newPosition);
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0f, 1f);
        viewportPosition.y = Mathf.Clamp(viewportPosition.y, 0f, 1f);
        newPosition = Camera.main.ViewportToWorldPoint(viewportPosition);
        newPosition.z = 0;

        // 位置を更新する
        this.transform.position = newPosition;
        lastMousePosition = Input.mousePosition;

        // 射撃
        time += Time.deltaTime;
        time2 += Time.deltaTime;

        if (Input.GetButton("Fire1") && time > ti)
        {
            Instantiate(aA);
            click = true;
            Instantiate(bom);
            Instantiate(bom2, transform.position, Quaternion.identity);
            time = 0;
            time2 = 0;

            if (gamepad is DualSenseGamepadHID dualSense)
            {
                dualSense.SetMotorSpeeds(1f, 1f);
                isVibrating = true;
               
            }
          
        }
  
        if(time2 >= ti3)
        {
            click = false;
        }
        if (isVibrating && time2 >= ti2)
        {
            if (gamepad is DualSenseGamepadHID dualSense)
            {
                dualSense.SetMotorSpeeds(0f, 0f);
                isVibrating = false;
            }

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (click)
        {
            scoree += 100;
            score.text = scoree.ToString();
            Destroy(collision.gameObject);
        }
     
    }
  

}
