using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float speed = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }
    public void ResetBall()
{
    // Untuk dibuat balik ke tengah
    _rigidbody.position = Vector2.zero;
    _rigidbody.linearVelocity = Vector2.zero;

    Invoke(nameof(AddStartingForce), 1f);
}

private void AddStartingForce()
{
    float x = Random.value < 0.5f ? -1f : 1f;
    
    float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

    Vector2 direction = new Vector2(x, y);
    _rigidbody.AddForce(direction * speed);
}
}