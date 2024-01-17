using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int _tipo;
    public int _vida;
    [SerializeField] bool _vivo;

    void Start()
    {
        gameObject.name = "Inimigo";    
    }

    
    void Update()
    {
        
    }
}
