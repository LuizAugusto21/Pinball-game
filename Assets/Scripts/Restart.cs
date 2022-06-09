using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public Button RestartButton;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(Reset);
        scene = SceneManager.GetActiveScene(); 
    }

    void Reset(){
       
        SceneManager.LoadScene(scene.name);
        
    }
}
