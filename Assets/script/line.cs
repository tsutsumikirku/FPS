using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public GameObject startObject;  // ����`�悷��J�n�_�ƂȂ�Q�[���I�u�W�F�N�g
    private LineRenderer lineRenderer;

    void Start()
    {
        // LineRenderer�R���|�[�l���g���擾�܂��͒ǉ�
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }

        // LineRenderer�̐ݒ�
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

        // �J�n�_�̈ʒu��ݒ�
        Vector3 startPosition = startObject.transform.position;

        // �}�E�X�|�W�V�������擾���A���[���h���W�ɕϊ�
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; // �}�E�X�ʒu��Z���W���J������near clip plane�ɐݒ�
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // LineRenderer�̒��_��ݒ�
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, worldMousePosition);
    }
}
