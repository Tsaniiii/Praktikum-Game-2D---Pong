using UnityEngine;

public partial class ComputerPaddle : Paddle
{
    [SerializeField] private Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.linearVelocity.x > 0.0f)
        {
            if (ball.position.y > transform.position.y + 0.5f) {
                _rigidbody.AddForce(Vector2.up * speed);
            } 
            else if (ball.position.y < transform.position.y + 0.5f) {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
    }

}