using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gatilhos : MonoBehaviour
{
    public float descanso = 0f;
    public float pressionado = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hj;

    public string inputName;


    void Start()
    {
        hj = GetComponent<HingeJoint>();
        hj.useSpring = true;
    }

    
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        
        if(Input.GetAxis(inputName)==1)
        {
            spring.targetPosition = pressionado;
        }
        else{
            spring.targetPosition = descanso;
        }
        hj.spring = spring;
        hj.useLimits = true; 
    }
}
