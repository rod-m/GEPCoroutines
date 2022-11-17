using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSomething : MonoBehaviour
{
    private IEnumerator coroutineFadeOut;
    void Start()
    {
        coroutineFadeOut = FadeOut(0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(coroutineFadeOut);
        }
    }
    IEnumerator FadeOut(float _rate)
    {
        var mat = GetComponent<Renderer>().material;
        for (float f = 1f; f >= 0; f -= _rate)
        {
            Color c = mat.color;
            c.a = f;
            mat.color = c;
            //Debug.Log($"fading out {f}");
            yield return new WaitForSeconds(0.1f);
        }
    }
}
