using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCilindros : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject ScriptBolinha;

    void OnCollisionEnter(Collision objeto){

        ScriptBolinha.GetComponent<DisparoBola>().pontuacao+=100;
        Debug.Log(ScriptBolinha.GetComponent<DisparoBola>().pontuacao);
    }
}
