using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBola : MonoBehaviour
{
    /* Rigidbody rb; */
    public GameObject Bolinha;
    public float increasedStrength = 50f;
    public float currentStrenght = 0f;
    public float STRENGHT_MIN = 500f;
    public float STRENGHT_LIMIT = 3000f;
    public bool canPush = false;
    public int QtdBolinha = 3;

    void OnCollisionEnter()
    {
        canPush = true;
    }

    void OnCollisionExit()
    {
        canPush = false;

        currentStrenght = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentStrenght = STRENGHT_MIN;
    }

    // Update is called once per frame
    void Update()
    {
        if (canPush && Input.GetKey(KeyCode.Space))
        {
            if (currentStrenght < STRENGHT_LIMIT)
            {
                currentStrenght += increasedStrength;
            }
        }

        if (canPush && Input.GetKeyUp(KeyCode.Space))
        {
            if (currentStrenght < STRENGHT_MIN)
            {
                currentStrenght = STRENGHT_MIN;
            }

            Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);

            Bolinha.GetComponent<Rigidbody>().AddForce(vector * currentStrenght);
        }
    }
}
