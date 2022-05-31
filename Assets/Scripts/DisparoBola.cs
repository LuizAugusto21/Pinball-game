using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBola : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vector = new Vector3(0.0f, 1.0f, 1.0f);

            rb.AddForce(vector * 1000f);
        }
    }
}
