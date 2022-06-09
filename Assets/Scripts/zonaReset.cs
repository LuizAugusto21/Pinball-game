using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaReset : MonoBehaviour
{
    public GameObject ScriptDisparo;

     void OnTriggerEnter(Collider bola)
     {
        bola.transform.position = new Vector3(9.01f, 143.84f, -195.86f);
        ScriptDisparo.GetComponent<DisparoBola>().QtdBolinha--;
    }
}
