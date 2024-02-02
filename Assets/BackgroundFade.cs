using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundFade : MonoBehaviour
{
    [SerializeField] Image _imagem;
    [SerializeField] float _fadeSpeed;
    void Start()
    {
        _imagem = GetComponent<Image>();
        StartCoroutine(FadeImagem());
    }

    IEnumerator FadeImagem()
    {
        _imagem.DOFade(255, _fadeSpeed);
        yield return null;
    }
    
    void Update()
    {
        
    }
}
