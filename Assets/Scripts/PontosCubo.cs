using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCubo : MonoBehaviour
{
    public GameObject ScriptBolinha;

    void OnCollisionEnter(Collision objeto){

        ScriptBolinha.GetComponent<DisparoBola>().pontuacao+=200;
        Debug.Log(ScriptBolinha.GetComponent<DisparoBola>().pontuacao);

        //Impulsona a bolinha pra cima ao toca no objeto
        Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);
        ScriptBolinha.GetComponent<Rigidbody>().AddForce(1000*vector);
    }
}
