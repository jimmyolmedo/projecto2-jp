using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apuntador : MonoBehaviour
{

    public Vector3 mousePosition;
    public Transform aimTransform;
    public bool enLaMira;
    public int damage;
    Collider2D colliderEnemigo;

    void Start()
    {

    }


    void Update()
    {
        MoverMira();

        Ataque();
    }


    public void MoverMira()
    {
        mousePosition = Input.mousePosition;
        Vector3 aimPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        aimTransform.position = new Vector3(aimPosition.x, aimPosition.y, aimTransform.position.z);
    }


    public void Ataque()
    {
        if (enLaMira == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (enLaMira == true)
            {
                colliderEnemigo.GetComponent<enemy>().Damage(damage);
            }
        }

    }


     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            colliderEnemigo = collision;
            enLaMira = true;

        }

    }





    private void OnTriggerExit2D(Collider2D collision)
    {
        enLaMira = false;
        colliderEnemigo = null;
    }

}
