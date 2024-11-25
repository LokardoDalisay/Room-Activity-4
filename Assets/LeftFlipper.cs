using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(25f);
        }
        else
        {
            rb.AddTorque(-20f);
        }
    }
}
