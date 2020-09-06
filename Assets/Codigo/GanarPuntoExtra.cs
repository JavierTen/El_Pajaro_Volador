using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanarPuntoExtra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Puntaje.puntaje += 2;
        
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Pajaro")
        {
            Destroy(gameObject, .1f);
        }
    }

}
