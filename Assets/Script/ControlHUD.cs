using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlHUD : MonoBehaviour
{
    [SerializeField] Image _img;
    [SerializeField] Button _bt1;
    [SerializeField] RectTransform _rectTransform;

    void Start()
    {
        _img.color = Color.green;
        _bt1 = _img.GetComponent<Button>();    
        _rectTransform = _img.GetComponentInParent<RectTransform>();
        //GetComponent<Camera>(); <-- Se faz assim para o método GetComponent localizar esse componente no GameObject que possui essa classe
    }

    
    void Update()
    {
        
    }
}
