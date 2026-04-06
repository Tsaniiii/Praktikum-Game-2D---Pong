using UnityEngine;

public partial class ComputerPaddle : Paddle
{
    // Kita butuh referensi ke bola untuk dikejar
    [SerializeField] private Rigidbody2D ball;

    private void FixedUpdate()
    {
        // Cek apakah bola bergerak ke arah AI (asumsi AI di kanan, x > 0)
        if (ball.linearVelocity.x > 0.0f)
        {
            // Jika bola lebih tinggi dari paddle, gerak ke atas
            if (ball.position.y > transform.position.y) {
                _rigidbody.AddForce(Vector2.up * speed);
            } 
            // Jika bola lebih rendah, gerak ke bawah
            else if (ball.position.y < transform.position.y) {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
    }

}