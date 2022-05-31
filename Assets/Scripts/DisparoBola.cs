using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBola : MonoBehaviour
{
    Rigidbody rb;
    public float strenght = 1000f;
    public float STRENGHT_LIMIT = 2300f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log(strenght);

            if (strenght < STRENGHT_LIMIT)
            {
                strenght += 10;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);

            rb.AddForce(vector * strenght);
        }
    }
}
