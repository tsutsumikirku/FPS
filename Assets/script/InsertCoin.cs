using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InsertCoin : MonoBehaviour
{
    public Text uiText;
    public float duration = 2.0f; // フェードイン・フェードアウトの時間

   

    void Start()
    {
        if (uiText != null)
        {
            StartCoroutine(FadeLoop());
        }
    
    }

    IEnumerator FadeLoop()
    {
        while (true)
        {
            yield return StartCoroutine(FadeTextToFullAlpha());
            yield return StartCoroutine(FadeTextToZeroAlpha());
        }
    }

    IEnumerator FadeTextToFullAlpha()
    {
        Color color = uiText.color;
        for (float t = 0.0f; t < duration; t += Time.deltaTime)
        {
            color.a = Mathf.Lerp(0, 1, t / duration);
            uiText.color = color;
            yield return null;
        }
        color.a = 1;
        uiText.color = color;
    }

    IEnumerator FadeTextToZeroAlpha()
    {
        Color color = uiText.color;
        for (float t = 0.0f; t < duration; t += Time.deltaTime)
        {
            color.a = Mathf.Lerp(1, 0, t / duration);
            uiText.color = color;
            yield return null;
        }
        color.a = 0;
        uiText.color = color;
    }
  
}
