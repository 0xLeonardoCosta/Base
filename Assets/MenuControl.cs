using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    [SerializeField] List<Transform> _itensMenu;

    void Start()
    {
        StartCoroutine(TimeItens());
    }

    private IEnumerator TimeItens()
    {
        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].localScale = Vector3.zero;
        }
        yield return new WaitForSeconds(1);

        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].DOScale(1.2f, .25f);
            yield return new WaitForSeconds(.25f);
            _itensMenu[i].DOScale(1, .25f);
        }
    }
    
    void Update()
    {
        
    }
}
