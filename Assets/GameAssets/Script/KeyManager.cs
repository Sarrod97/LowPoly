using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
  public GameObject imagenllave;

     void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.name=="Llave")
        {
            Destroy(c.gameObject);
            imagenllave.SetActive(true);
        }
    }
}
