using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    public void OnMove(InputValue value)
    {
        _direction = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}

