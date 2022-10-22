using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoriaJugador : MonoBehaviour
{

    public float numeroLlaves;

    public GameObject puerta;

    // Start is called before the first frame update
    void Start()
    {
        numeroLlaves = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(numeroLlaves == 10) {
            Destroy(puerta);
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "llaves") {
            numeroLlaves = numeroLlaves + 1;
            Debug.Log("Aumentó numero de llaves");
            Destroy(collision.gameObject);
        }
        
    }




}
