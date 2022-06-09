using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCapsula : MonoBehaviour
{
    public GameObject ScriptBolinha;

    void OnCollisionEnter(Collision objeto){

        ScriptBolinha.GetComponent<DisparoBola>().pontuacao+=500;
        Debug.Log(ScriptBolinha.GetComponent<DisparoBola>().pontuacao);

    }
}
