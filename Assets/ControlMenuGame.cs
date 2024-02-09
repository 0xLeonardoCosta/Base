using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuGame : MonoBehaviour
{
    [SerializeField] Transform[] _iconVida;
    [SerializeField] Transform _telaGameOver;
    void Start()
    {
        //StartCoroutine(StartCanvas());
        //_iconVida[2].DOScale(0, 0.5f);
    }

    public void CheckIconVida(int vida)
    {
        if (vida == 0)
        {
            _iconVida[0].DOScale(0, 0.5f);
            _telaGameOver.DOScale(1, 0.5f);
        }
        else if (vida == 1)
        {
            _iconVida[1].DOScale(0, 0.5f);
        }
        else if (vida == 2)
        {
            _iconVida[2].DOScale(0, 0.5f);
        }
    }

    void Update()
    {

    }

    /*IEnumerator StartCanvas()
    {
        for (int i = 0; i < _iconVida.Length; i++)
        {
            _iconVida[i].DOScale(0, 0.5f);
        }
        yield return 2;
        _iconVida[0].DOScale(1, 0.5f);

        for (int i = 0; i < _iconMana.Length; i++)
        {
            _iconMana[i].DOScale(0, 0.5f);
        }
        yield return 4;
        _iconMana[0].DOScale(1, 0.5f);
    }*/
}
