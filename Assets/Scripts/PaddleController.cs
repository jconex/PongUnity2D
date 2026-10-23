
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float velocidad = 8f;
    public KeyCode teclaArriba = KeyCode.W;
    public KeyCode teclaAbajo = KeyCode.S;

    private Rigidbody2D rb;
    private float movimiento;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimiento = 0;

        if (Input.GetKey(teclaArriba))
            movimiento = 1;

        if (Input.GetKey(teclaAbajo))
            movimiento = -1;
    }

    void FixedUpdate()
    {
        Vector2 nuevaPosicion = rb.position +
            Vector2.up * movimiento *
            velocidad * Time.fixedDeltaTime;

        nuevaPosicion.y =
            Mathf.Clamp(nuevaPosicion.y, -3.8f, 3.8f);

        rb.MovePosition(nuevaPosicion);
    }
}
