using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    public float jumpVelocity = 5.5f;
    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;

    private float _horizontal;
    private float _vertical;
    private bool _isJumping;
    private Quaternion _angleRot = Quaternion.identity;
    private Rigidbody _rb;
    private CapsuleCollider _col;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _col = this.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal") * rotateSpeed;
        _vertical = Input.GetAxis("Vertical") * moveSpeed;
        _isJumping |= Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _horizontal;
        _angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        Move();
        Jump();
    }

    public void Move()
    {
        _rb.MovePosition(this.transform.position + this.transform.forward * _vertical * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * _angleRot);
    }

    public void Jump()
    {
        if (IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;
    }

    bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }
}
