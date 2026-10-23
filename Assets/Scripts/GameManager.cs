
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallController pelota;
    public TMP_Text marcadorTexto;
    private int puntosJugador1 = 0;
    private int puntosJugador2 = 0;

    void Update()
    {
        float x = pelota.transform.position.x;

        if (x < -9.5f)
        {
            puntosJugador2++;
            Reiniciar();
        }
        else if (x > 9.5f)
        {
            puntosJugador1++;
            Reiniciar();
        }
    }

    void Reiniciar()
    {
        marcadorTexto.text =
            puntosJugador1 + "  :  " + puntosJugador2;

        pelota.LanzarPelota();
    }
}
