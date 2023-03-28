using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverseCodigo : MonoBehaviour
{
    //el personaje se mueve hacia ambos lados

    public float speed = 5f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

//https://skribbl.io/?SlCv7UM2
}
