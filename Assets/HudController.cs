using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudController : MonoBehaviour // Essa classe fica no gameObject pai de todos os paineis de menu
{
    [SerializeField] List<MenuControl> _menuControl; // Essa lista está pegando todos os paineis filhos (jogar, opcoes, sair)
    void Start()
    {
        for (int i = 0; i < _menuControl.Count; i++)
        {
            _menuControl[i].transform.localScale = Vector3.zero;
            _menuControl[i].gameObject.SetActive(false);
        }
        _menuControl[0].gameObject.SetActive(true);
        _menuControl[0].MenuOff();
        _menuControl[0].transform.DOScale(1f, .25f);
        _menuControl[0].ChamarMenu();
    }
    
    public void ChamarMenuControl(int value)
    {
        for (int i = 0; i < _menuControl.Count; i++)
        {
            _menuControl[i].transform.localScale = Vector3.zero;
            _menuControl[i].MenuOff();
            _menuControl[i].gameObject.SetActive(false);
        }
        _menuControl[value].gameObject.SetActive(true);
        _menuControl[value].transform.DOScale(1f, .25f);
        _menuControl[value].ChamarMenu();
    }
}
