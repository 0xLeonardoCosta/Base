using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _speedRot;

    [SerializeField] ControlMenuGame _controlMenuGame;
    [SerializeField] int _quantVida;
    
    void Start()
    {
                    
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h > 0 || v > 0)
        {
            //transform.rotate(90 * _speedRot * Time.deltaTime, 0, 0);
        }

        transform.Translate(h * _speed * Time.deltaTime, v * _speed * Time.deltaTime, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hit")
        {
            _quantVida--;
            _controlMenuGame.CheckIconVida(_quantVida);
        }
    }
}
