using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlleMenu : MonoBehaviour
{
    [SerializeField] List<Button> _btMenuP = new List<Button>();

    [SerializeField] GameObject _player;

    [SerializeField] public int _value;

    void Start()
    {
        for (int i = 0; i < _btMenuP.Count; i++)
        {
            //_btMenuP[i].GetComponent<Image>().raycastTarget = false;
            //_btMenuP[i].GetComponent<Button>().interactable = false;
        }
    }

    public void BtsPrincipal(int value)
    {
        if (value == 0)
        {
            Debug.Log("Jogar");
        }
        else if (value == 1)
        {
            Debug.Log("Carregar");
        }
        else if (value == 2)
        {
            Debug.Log("Opções");
        }
        else if (value == 3)
        {
            Debug.Log("Sair");
        }
    }
    public void Jogar()
    {
        Debug.Log("Jogar");
    }
    public void Carregar()
    {
        Debug.Log("Carregar");
    }public void Opcao()
    {
        Debug.Log("Opcao");
    }
    
    void Update()
    {
        
    }
}
