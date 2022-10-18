using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    GameObject generadorActivo;
    GameObject enemigo;

    public float dist;


    void Start()
    //este codigo define las colisiones del enemigo
    //es decir con jugador game over
    //y con generadores de ruido que los destruye

    {
        player = GameObject.FindWithTag("Player");
        //generadorActivo = GameObject.FindWithTag("generadorRuido");

        enemigo = GameObject.FindWithTag("enemigo");
        generadorActivo = GameObject.FindWithTag("generadorRuido");

    }

    // Update is called once per frame
    void Update()
    {
        generadorActivo = GameObject.FindWithTag("generadorRuido");

        DetectarDistancia();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { Debug.Log("Codigo GAME OVER aqui"); }
        if (collision.gameObject.tag == "generadorRuido") { Debug.Log("destruido"); Destroy(collision.gameObject); }
        //generadorActivo.gameObject.tag="nulo";
    }

    void DetectarDistancia()
    {
        dist = Vector3.Distance(enemigo.transform.position, generadorActivo.transform.position);
        Debug.Log(dist);
    }

}

