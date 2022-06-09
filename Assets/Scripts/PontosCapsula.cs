using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCapsula : MonoBehaviour
{
    public GameObject ScriptScore;

    void OnCollisionEnter(Collision objeto){

        ScriptScore.GetComponent<AtualizaScore>().score+=500;
        Debug.Log(ScriptScore.GetComponent<AtualizaScore>().score);

    }
}
