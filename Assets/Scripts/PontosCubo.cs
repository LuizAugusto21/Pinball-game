using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosCubo : MonoBehaviour
{
    public GameObject ScriptScore;

    void OnCollisionEnter(Collision objeto){

        ScriptScore.GetComponent<AtualizaScore>().score+=200;
        Debug.Log(ScriptScore.GetComponent<AtualizaScore>().score);

        //Impulsona a bolinha pra cima ao toca no objeto
        Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);
        ScriptScore.GetComponent<Rigidbody>().AddForce(1000*vector);
    }
}
