using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaReset : MonoBehaviour
{
     void OnTriggerEnter(Collider bola)
     {
        Debug.Log("entrou");
        bola.transform.position = new Vector3(9.01f, 141.84f, -197.12f);
        //bola.startGame = true;
    }
}