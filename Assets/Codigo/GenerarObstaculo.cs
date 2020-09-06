using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObstaculo : MonoBehaviour
{
    public float maxTIme = 1;
    public float timer = 0;
    public GameObject pipe;
    public float posicion;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(newpipe, 5);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTIme)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-posicion, posicion), 0);
            Destroy(newpipe, 5);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

   

}
