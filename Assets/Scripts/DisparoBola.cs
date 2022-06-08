using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBola : MonoBehaviour
{
    Rigidbody rb;
    public float strenght = 1000f;
    public float STRENGHT_LIMIT = 2300f;
    public Vector3 startPosition;
    public bool startGame = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = new Vector3(9.01f, 141.84f, -197.12f);
    }

    // Update is called once per frame
    void Update()
    {   
        if(startPosition == new Vector3(9.01f, 141.84f, -197.12f)){
            startGame = true;
        }
        if (startGame && Input.GetKey(KeyCode.Space))
        {
            //Debug.Log(strenght);

            if (strenght < STRENGHT_LIMIT)
            {
                strenght += 10;
            }
        }

        if (startGame && Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);

            rb.AddForce(vector * strenght);

            startGame = false;
        }
    }
}
