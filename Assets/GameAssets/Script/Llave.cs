using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    // Para que rote la llave
    public float speed;
    

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);  

    }

 
}

