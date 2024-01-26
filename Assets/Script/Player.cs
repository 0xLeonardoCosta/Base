using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _degrade = 5f;

    [SerializeField] SpriteRenderer _spr;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] CapsuleCollider2D _capsuleCollider;

    void Start()
    {
        gameObject.name = "Player";

        _spr = GetComponent<SpriteRenderer>();
        _spr.color = Color.blue;

        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0f;

        _capsuleCollider = GetComponent<CapsuleCollider2D>();
        _capsuleCollider.isTrigger = false;
    }
   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate( h * _speed * Time.deltaTime, v * _speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Inimigo"))
        {
            //collision.GetComponent<Inimigo>()._tipo += 1;

            if (collision.GetComponent<Inimigo>()._tipo == 0)
            {
                collision.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            else if (collision.GetComponent<Inimigo>()._tipo == 1)
            {
                collision.GetComponent<SpriteRenderer>().color = Color.red;
            }

            //collision.GetComponent<SpriteRenderer>().color = Color.red;
            //collision.GetComponent<SpriteRenderer>().color = Color.Lerp (Color.red, Color.blue, 5f);
        }
    }
}