using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCilindros : MonoBehaviour
{
    public GameObject ScriptBolinha;

    void OnCollisionEnter(Collision objeto){

        ScriptBolinha.GetComponent<DisparoBola>().pontuacao+=100;
        Debug.Log(ScriptBolinha.GetComponent<DisparoBola>().pontuacao);
    }
}
