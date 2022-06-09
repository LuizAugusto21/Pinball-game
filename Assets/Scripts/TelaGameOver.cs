using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaGameOver : MonoBehaviour
{

    public RectTransform PanelGameOver;
    public bool gameOver;
    public GameObject ScriptDisparo;

    public Vector3 emcima, centroDaTela;
    // Start is called before the first frame update
    void Start()
    {
        centroDaTela = new Vector3(PanelGameOver.position.x, Screen.height/2, PanelGameOver.position.z);
        emcima = new Vector3(PanelGameOver.position.x, Screen.height*1.5f, PanelGameOver.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver){
            PanelGameOver.position = emcima;
            Time.timeScale =1;
        }
        else{
            PanelGameOver.position = centroDaTela;
            //PanelGameOver.position = Vector3.Lerp(PanelGameOver.position, centroDaTela, Time.deltaTime*10);
            Time.timeScale =0;
        }

        if(ScriptDisparo.GetComponent<DisparoBola>().QtdBolinha==0 && !gameOver){
            gameOver = !gameOver;

        }

    }
}
