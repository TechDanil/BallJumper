using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    [SerializeField] private Rigidbody _ridgidBody;
    
    private void Start()
    {
        _ridgidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformSegment platformSegment))
        {
            _ridgidBody.velocity = Vector3.zero;
            _ridgidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
