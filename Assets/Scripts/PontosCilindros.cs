using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCilindros : MonoBehaviour
{
    public GameObject ScriptScore;

    void OnCollisionEnter(Collision objeto){

        ScriptScore.GetComponent<AtualizaScore>().score+=100;
        Debug.Log(ScriptScore.GetComponent<AtualizaScore>().score);
    }
}
