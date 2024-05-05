using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;

    [Header("Settings")]
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        moveDirection = moveDirection.normalized;
        rb.velocity = new Vector3((moveDirection.x * moveSpeed * Time.deltaTime), rb.velocity.y, (moveDirection.z * moveSpeed * Time.deltaTime));
    }
}
