using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public int vida;

    void Start()
    {
        
    }


    void Update()
    {
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        vida = vida - damage;
    }

}
