using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonbiControl : MonoBehaviour
{
    [SerializeField] float initialScaleSpeed = 0.1f; // �����̃X�P�[�����x
    Vector3 maxScale = new Vector3(0.7f, 0.7f, 0.7f);
    GameDirecter _game;
    int sssss = 1;
    
    private float elapsedTime = 0f; // �o�ߎ���


    // Start is called before the first frame update
    private void Start()
    {
        var g = GameObject.Find("GameDirector");
        _game = g.GetComponent<GameDirecter>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // �o�ߎ��Ԃ��X�V
        float scaleSpeed = initialScaleSpeed * (1 + elapsedTime); // �o�ߎ��ԂɊ�Â��ăX�P�[�����x�𑝉�

        Vector3 currentScale = transform.localScale;
        currentScale += Vector3.one * scaleSpeed * Time.deltaTime;
        transform.localScale = currentScale;

        

        if (currentScale.x >= maxScale.x || currentScale.y >= maxScale.y || currentScale.z >= maxScale.z)
        {

            _game.Hpc(sssss);
            
            Destroy(gameObject);
       
        }
    }
}
