using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoChar : MonoBehaviour
{
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        float velZ = Input.GetAxis("Vertical");
        float velX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector3(velX, _rb.velocity.y, velZ);
    }
}

