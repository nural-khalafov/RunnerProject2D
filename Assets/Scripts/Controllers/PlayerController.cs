using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private Vector2 _direction;

    private float _tapInterval = 0.35f;
    private float _lastTapTime;


    [SerializeField]
    private bool _intertedGravity = false;

    public float JumpScale = 15f;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            float timeSinceLastTap = Time.time - _lastTapTime;

            if (timeSinceLastTap <= _tapInterval)
            {
                if (!_intertedGravity)
                {
                    _intertedGravity = true;
                    _rigidbody.gravityScale = -5f;
                }
                else
                {
                    _intertedGravity = false;
                    _rigidbody.gravityScale = 5f;
                }
            }
            _lastTapTime = Time.time;

            if (_intertedGravity)
            {
                _rigidbody.velocity = Vector2.down * JumpScale;
            }
            else
                _rigidbody.velocity = Vector2.up * JumpScale;
        }
    }
}
