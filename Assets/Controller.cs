using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Physics")]
    [SerializeField] Rigidbody rb;

    [SerializeField] float speed;
    [SerializeField] float moveX;
    [SerializeField] float moveZ;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
        Move();
    }

    void GetInput()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        rb.velocity = new Vector3(moveX, rb.velocity.y, moveZ) * speed;
    }
}
