using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed;

    void Start()
    {
        gameObject.name = "Player";
    }
   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertital");

        //transform.position = transform.Translate(h , v, transform.position.z) * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Inimigo"))
        {
            collision.GetComponent<SpriteRenderer>().color = Color.blue;  

            if (collision.GetComponent<Inimigo>()._tipo == 1)
            {
                collision.GetComponent<Inimigo>()._vida -= 5;
            }
            else if (collision.GetComponent<Inimigo>()._tipo == 2)
            {
                collision.GetComponent<Inimigo>()._vida -= 3;
            }
        }
    }
}
