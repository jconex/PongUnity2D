
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocidad = 7f;
    public float velocidadMaxima = 14f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        LanzarPelota();
    }

    public void LanzarPelota()
    {
        rb.linearVelocity = Vector2.zero;
        rb.position = Vector2.zero;

        float direccionX =
            Random.value > 0.5f ? 1f : -1f;

        float direccionY = Random.Range(-0.7f, 0.7f);

        Vector2 direccion =
            new Vector2(direccionX, direccionY).normalized;

        rb.linearVelocity = direccion * velocidad;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float nuevaVelocidad =
                Mathf.Min(
                    rb.linearVelocity.magnitude * 1.05f,
                    velocidadMaxima
                );

            Vector2 direccion =
                rb.linearVelocity.normalized;

            rb.linearVelocity =
                direccion * nuevaVelocidad;
        }
    }
}
