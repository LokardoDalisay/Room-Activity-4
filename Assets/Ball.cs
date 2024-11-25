using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;
    float gravity = 9.8f;
    float bouncy = 25f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(new Vector2(gravity * bouncy, gravity * bouncy));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
