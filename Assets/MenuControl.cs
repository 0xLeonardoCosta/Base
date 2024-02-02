using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] List<Transform> _itensMenu;

    private IEnumerator TimeItens()
    {
        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].DOScale(1.2f, .25f);
            yield return new WaitForSeconds(.25f);
            _itensMenu[i].DOScale(1, .25f);
        }
    }
    
    public void ChamarMenu()
    {
        _itensMenu[0].GetComponent<Button>().Select();
        StartCoroutine(TimeItens());
    }
    public void MenuOff()
    {
        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].transform.localScale = Vector3.zero;
        }
    }
}
