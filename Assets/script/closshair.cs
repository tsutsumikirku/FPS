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
        // �}�E�X�J�[�\��������
        Cursor.visible = false;
        time = ti;
    }

    void Update()
    {
     
        // Camera.main �Ń��C���J�����iMainCamera �^�O�̕t���� Camera�j���擾����
        // Camera.ScreenToWorldPoint �֐��ŁA�X�N���[�����W�����[���h���W�ɕϊ�����
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;    // Z ���W���J�����Ɠ����ɂȂ��Ă���̂ŁA���Z�b�g����
        this.transform.position = mousePosition;


        //�ˌ�
        time += Time.deltaTime;
        if (Input.GetButton("Fire1") && time > ti)
        {
            Instantiate(bom);
            Instantiate(bom2).transform.position = this.gameObject.transform.position;
            time = 0;
        }
        
    }
     

}
