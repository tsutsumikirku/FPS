using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public GameObject startObject;  // 線を描画する開始点となるゲームオブジェクト
    private LineRenderer lineRenderer;

    void Start()
    {
        // LineRendererコンポーネントを取得または追加
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }

        // LineRendererの設定
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    void Update()
    {
        if (startObject == null)
        {
            Debug.LogError("Start Object is not assigned.");
            return;
        }

        // 開始点の位置を設定
        Vector3 startPosition = startObject.transform.position;

        // マウスポジションを取得し、ワールド座標に変換
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; // マウス位置のZ座標をカメラのnear clip planeに設定
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // LineRendererの頂点を設定
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, worldMousePosition);
    }
}
