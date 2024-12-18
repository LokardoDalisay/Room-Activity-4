using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D _rb;
    Vector3 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = _rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, col.contacts[0].normal);

        _rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
